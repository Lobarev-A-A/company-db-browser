﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CompanyDBBrowser.App
{
    public partial class MainForm : Form
    {
        CultureInfo culture = new CultureInfo("ru-RU");
        Model dataBase;

        public MainForm()
        {
            InitializeComponent();

            dataBase = new Model();

            var departments = dataBase.Departments;

            // Установка CompanyNameLabel
            var company = departments.Where(d => d.ParentDepartmentID == null);
            if (company.Count() == 1)
            {
                CompanyNameLabel.Text = company.First().Name;
            }
            else
            {
                // Обработка отстутствия в Department единственной записи с NULL значением ParentDepartmentID,
                // принимаемой за фирму целиком
            }

            ShowDepartmentsInTreeView(departments);
            ShowDepartmentsInListBox(departments);

            #region Set default condition of form elements
            AddDepartmentButton.Enabled = false;
            EditDepartmentButton.Enabled = false;
            removeDepartmentButton.Enabled = false;
            TreeViewRadioButton.Checked = true;
            DepartmentListBox.Visible = false;
            DepartmentTreeView.Visible = true;
            EditEmployeeButton.Enabled = false;
            removeEmployeeButton.Enabled = false;
            #endregion

            #region EmployeesGridView Header
            EmployeesGridView.ColumnCount = 11;
            EmployeesGridView.Columns[0].Name = "ID";
            EmployeesGridView.Columns[1].Name = "Фамилия";
            EmployeesGridView.Columns[2].Name = "Имя";
            EmployeesGridView.Columns[3].Name = "Отчество";
            EmployeesGridView.Columns[4].Name = "Дата рождения";
            EmployeesGridView.Columns[5].Name = "Возраст";
            EmployeesGridView.Columns[6].Name = "Серия документа";
            EmployeesGridView.Columns[7].Name = "Номер документа";
            EmployeesGridView.Columns[8].Name = "Отдел";
            EmployeesGridView.Columns[9].Name = "Должность";
            EmployeesGridView.Columns[10].Name = "ID отдела";
            #endregion
        }

        private TreeNode TreeViewRecursiveInitialization(Department curDepartment, System.Data.Entity.DbSet<Department> departments)
        {
            var childrenDepartments = departments.Where(d => d.ParentDepartmentID == curDepartment.ID);
            TreeNode[] childrenTreeNodes = new TreeNode[childrenDepartments.Count()];

            int i = 0;
            foreach (var d in childrenDepartments)
            {
                childrenTreeNodes[i] = TreeViewRecursiveInitialization(d, departments);
                i++;
            }

            TreeNode outputTreeNode = new TreeNode(curDepartment.Name, childrenTreeNodes);
            outputTreeNode.Tag = curDepartment;
            return outputTreeNode;
        }

        private void TreeViewRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DepartmentListBox.Visible = false;
            DepartmentTreeView.Visible = true;
        }
        private void ListViewRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DepartmentListBox.Visible = true;
            DepartmentTreeView.Visible = false;
        }

        private void DepartmentTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Department selectedDepartment = (Department)DepartmentTreeView.SelectedNode.Tag;
            ShowDepartmentDetails(selectedDepartment);
            ShowDepartmentEmployees(selectedDepartment);
            EditEmployeeButton.Enabled = true;
            removeEmployeeButton.Enabled = true;
        }
        private void DepartmentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DepartmentListBox.SelectedIndex != -1)
            {
                Department selectedDepartment = (Department)DepartmentListBox.SelectedItem;
                ShowDepartmentDetails(selectedDepartment);
                ShowDepartmentEmployees(selectedDepartment);
                EditEmployeeButton.Enabled = true;
                removeEmployeeButton.Enabled = true;
            }
        }

        private void ShowDepartmentDetails(Department selectedDepartment)
        {
            string parentDepartmentName = "";
            if (selectedDepartment.ParentDepartmentID != null)
                // Не учтена ситуация, когда в базе нет департамента с таким ID (хз, может ли она возникнуть)
                parentDepartmentName = dataBase.Departments.Find(selectedDepartment.ParentDepartmentID).Name;

            string[][] rows = new string[][]
            {
                new string[] { "ID", selectedDepartment.ID.ToString() },
                new string[] { "Название", selectedDepartment.Name },
                // new string[] { "Количество сотрудниов", selectedDepartment.Employees.Count.ToString() },
                new string[] { "Родительский отдел", parentDepartmentName },
                new string[] { "ID родительского отдела", selectedDepartment.ParentDepartmentID.ToString() }
            };

            DepartmentDetailsGridView.Rows.Clear();
            DepartmentDetailsGridView.ColumnCount = 2;

            foreach (string[] row in rows)
            {
                DepartmentDetailsGridView.Rows.Add(row);
            }
        }
        private void ShowDepartmentEmployees(Department selectedDepartment)
        {
            EmployeesGridView.Rows.Clear();

            foreach (Employee employee in selectedDepartment.Employees)
            {
                string[] row = { employee.ID.ToString(), employee.SurName, employee.FirstName, employee.Patronymic,
                                     employee.DateOfBirth.ToString("d", culture), "Age", employee.DocSeries, employee.DocNumber,
                                     employee.Department.Name, employee.Position, employee.DepartmentID.ToString()};

                EmployeesGridView.Rows.Add(row);
            }
        }
        private void ShowDepartmentsInListBox(DbSet<Department> departments)
        {
            DepartmentListBox.Items.Clear();
            foreach (var d in departments)
                DepartmentListBox.Items.Add(d);
            DepartmentListBox.Sorted = true;
        }
        private void ShowDepartmentsInTreeView(DbSet<Department> departments)
        {
            // Не обработана ситуация, когда нет записи с ParentDepartmentID == null
            DepartmentTreeView.Nodes.Add(TreeViewRecursiveInitialization(departments.Where(d => d.ParentDepartmentID == null).First(), departments));
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            // Определение выбранного отдела
            Department selectedDepartment;
            if (TreeViewRadioButton.Checked)
                selectedDepartment = (DepartmentTreeView.SelectedNode == null) ? null : (Department)DepartmentTreeView.SelectedNode.Tag;
            else
                selectedDepartment = (DepartmentListBox.SelectedItem == null) ? null : (Department)DepartmentListBox.SelectedItem;

            EmployeeForm addEmployeeForm = new EmployeeForm(dataBase.Departments, selectedDepartment, "Новый сотрудник");

            #region Validation
            bool correctValuesEntered = false;
            while (correctValuesEntered == false)
            {
                DialogResult dialogResult = addEmployeeForm.ShowDialog(this);

                if (dialogResult == DialogResult.Cancel)
                    return;
                correctValuesEntered = true;
                // Обязательные поля
                if (addEmployeeForm.surnameTextBox.Text == "")
                {
                    MessageBox.Show("Поле \"Фамилия\" должно быть заполнено!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correctValuesEntered = false;
                }
                if (addEmployeeForm.firstNameTextBox.Text == "")
                {
                    MessageBox.Show("Поле \"Имя\" должно быть заполнено!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correctValuesEntered = false;
                }
                if (addEmployeeForm.positionTextBox.Text == "")
                {
                    MessageBox.Show("Поле \"Должность\" должно быть заполнено!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correctValuesEntered = false;
                }
                // Длина строки
                if (addEmployeeForm.surnameTextBox.Text.Length > 50)
                {
                    MessageBox.Show("Поле \"Фамилия\" должно содержать не более 50 символов!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correctValuesEntered = false;
                }
                if (addEmployeeForm.firstNameTextBox.Text.Length > 50)
                {
                    MessageBox.Show("Поле \"Имя\" должно содержать не более 50 символов!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correctValuesEntered = false;
                }
                if (addEmployeeForm.patronymicTextBox.Text.Length > 50)
                {
                    MessageBox.Show("Поле \"Отчество\" должно содержать не более 50 символов!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correctValuesEntered = false;
                }
                if (addEmployeeForm.docSeriesTextBox.Text.Length > 4)
                {
                    MessageBox.Show("Поле \"Серия документа\" должно содержать не более 4 символов!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correctValuesEntered = false;
                }
                if (addEmployeeForm.docNumberTextBox.Text.Length > 6)
                {
                    MessageBox.Show("Поле \"Номер документа\" должно содержать не более 6 символов!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correctValuesEntered = false;
                }
                if (addEmployeeForm.positionTextBox.Text.Length > 50)
                {
                    MessageBox.Show("Поле \"Должность\" должно содержать не более 50 символов!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correctValuesEntered = false;
                }
            }
            #endregion

            Employee newEmployee = new Employee();
            newEmployee.SurName = addEmployeeForm.surnameTextBox.Text;
            newEmployee.FirstName = addEmployeeForm.firstNameTextBox.Text;
            newEmployee.Patronymic = addEmployeeForm.patronymicTextBox.Text;
            newEmployee.DateOfBirth = addEmployeeForm.dateOfBirthDateTimePicker.Value;
            newEmployee.DocSeries = addEmployeeForm.docSeriesTextBox.Text;
            newEmployee.DocNumber = addEmployeeForm.docNumberTextBox.Text;
            newEmployee.Position = addEmployeeForm.positionTextBox.Text;
            Department selectedInAddFormDepartment = (Department)addEmployeeForm.departmentComboBox.SelectedItem;
            newEmployee.DepartmentID = selectedInAddFormDepartment.ID;

            dataBase.Employees.Add(newEmployee);
            dataBase.SaveChanges();

            // Обновление отображаемого списка сотрудников
            if (selectedDepartment != null)
                ShowDepartmentEmployees(selectedDepartment);
        }
        private void EditEmployeeButton_Click(object sender, EventArgs e)
        {
            if (EmployeesGridView.Rows.Count == 0)
                return;

            int rowIndex = EmployeesGridView.SelectedRows[0].Index;
            string selectedEmployeeID = EmployeesGridView[0, rowIndex].Value.ToString();
            string selectedDepartmentID = EmployeesGridView[10, rowIndex].Value.ToString();
            Department selectedDepartment = dataBase.Departments.Where(d => d.ID.ToString() == selectedDepartmentID).First();
            Employee employee = dataBase.Employees.Where(emp => emp.ID.ToString() == selectedEmployeeID).First();

            EmployeeForm editEmployeeForm = new EmployeeForm(dataBase.Departments, selectedDepartment, "Редактирование данных сотрудника");

            editEmployeeForm.surnameTextBox.Text = employee.SurName;
            editEmployeeForm.firstNameTextBox.Text = employee.FirstName;
            editEmployeeForm.patronymicTextBox.Text = employee.Patronymic;
            editEmployeeForm.dateOfBirthDateTimePicker.Value = employee.DateOfBirth;
            editEmployeeForm.docSeriesTextBox.Text = employee.DocSeries;
            editEmployeeForm.docNumberTextBox.Text = employee.DocNumber;
            editEmployeeForm.positionTextBox.Text = employee.Position;

            #region Validation
            bool correctValuesEntered = false;
            while (correctValuesEntered == false)
            {
                DialogResult dialogResult = editEmployeeForm.ShowDialog(this);

                if (dialogResult == DialogResult.Cancel)
                    return;
                correctValuesEntered = true;
                // Обязательные поля
                if (editEmployeeForm.surnameTextBox.Text == "")
                {
                    MessageBox.Show("Поле \"Фамилия\" должно быть заполнено!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correctValuesEntered = false;
                }
                if (editEmployeeForm.firstNameTextBox.Text == "")
                {
                    MessageBox.Show("Поле \"Имя\" должно быть заполнено!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correctValuesEntered = false;
                }
                if (editEmployeeForm.positionTextBox.Text == "")
                {
                    MessageBox.Show("Поле \"Должность\" должно быть заполнено!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correctValuesEntered = false;
                }
                // Длина строки
                if (editEmployeeForm.surnameTextBox.Text.Length > 50)
                {
                    MessageBox.Show("Поле \"Фамилия\" должно содержать не более 50 символов!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correctValuesEntered = false;
                }
                if (editEmployeeForm.firstNameTextBox.Text.Length > 50)
                {
                    MessageBox.Show("Поле \"Имя\" должно содержать не более 50 символов!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correctValuesEntered = false;
                }
                if (editEmployeeForm.patronymicTextBox.Text.Length > 50)
                {
                    MessageBox.Show("Поле \"Отчество\" должно содержать не более 50 символов!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correctValuesEntered = false;
                }
                if (editEmployeeForm.docSeriesTextBox.Text.Length > 4)
                {
                    MessageBox.Show("Поле \"Серия документа\" должно содержать не более 4 символов!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correctValuesEntered = false;
                }
                if (editEmployeeForm.docNumberTextBox.Text.Length > 6)
                {
                    MessageBox.Show("Поле \"Номер документа\" должно содержать не более 6 символов!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correctValuesEntered = false;
                }
                if (editEmployeeForm.positionTextBox.Text.Length > 50)
                {
                    MessageBox.Show("Поле \"Должность\" должно содержать не более 50 символов!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correctValuesEntered = false;
                }
            }
            #endregion

            employee.SurName = editEmployeeForm.surnameTextBox.Text;
            employee.FirstName = editEmployeeForm.firstNameTextBox.Text;
            employee.Patronymic = editEmployeeForm.patronymicTextBox.Text;
            employee.DateOfBirth = editEmployeeForm.dateOfBirthDateTimePicker.Value;
            employee.DocSeries = editEmployeeForm.docSeriesTextBox.Text;
            employee.DocNumber = editEmployeeForm.docNumberTextBox.Text;
            employee.Position = editEmployeeForm.positionTextBox.Text;
            Department selectedInAddFormDepartment = (Department)editEmployeeForm.departmentComboBox.SelectedItem;
            employee.DepartmentID = selectedInAddFormDepartment.ID;

            dataBase.SaveChanges();
            // Обновление отображаемого списка сотрудников
            if (selectedDepartment != null)
                ShowDepartmentEmployees(selectedDepartment);
        }
        private void RemoveEmployeeButton_Click(object sender, EventArgs e)
        {
            if (EmployeesGridView.Rows.Count == 0)
                return;

            int rowIndex = EmployeesGridView.SelectedRows[0].Index;
            string selectedEmployeeID = EmployeesGridView[0, rowIndex].Value.ToString();
            string selectedDepartmentID = EmployeesGridView[10, rowIndex].Value.ToString();
            Department selectedDepartment = dataBase.Departments.Where(d => d.ID.ToString() == selectedDepartmentID).First();
            Employee employee = dataBase.Employees.Where(emp => emp.ID.ToString() == selectedEmployeeID).First();

            DialogResult result;
            if (employee.Patronymic != "")
                result = MessageBox.Show($"Удалить сотрудника {employee.SurName} {employee.FirstName} {employee.Patronymic}?",
                                         "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            else
                result = MessageBox.Show($"Удалить сотрудника {employee.SurName} {employee.FirstName}?",
                                         "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
                return;

            dataBase.Employees.Remove(employee);
            dataBase.SaveChanges();

            // Обновление отображаемого списка сотрудников
            if (selectedDepartment != null)
                ShowDepartmentEmployees(selectedDepartment);
        }
    }
}
