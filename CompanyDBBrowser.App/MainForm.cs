using System;
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
        #region Fields
        CultureInfo culture = new CultureInfo("ru-RU");

        Model dataBase;
        Department selectedDepartment;
        Employee selectedEmployee;
        #endregion

        public MainForm()
        {
            InitializeComponent();

            dataBase = new Model();

            var rootDepartments = dataBase.Departments.Where(d => d.ParentDepartmentID == null);
            if (rootDepartments.Count() == 0)
                throw new Exception("Невозможно построение структуры предприятия. Отсутствует корневой Department.");

            #region Set default condition of form elements
            companyNameLabel.Text = rootDepartments.First().Name;
            editDepartmentButton.Enabled = false;
            removeDepartmentButton.Enabled = false;
            treeViewRadioButton.Checked = true;
            departmentListBox.Visible = false;
            departmentTreeView.Visible = true;
            editEmployeeButton.Enabled = false;
            removeEmployeeButton.Enabled = false;
            addDepartmentButton.Enabled = true;

            #region EmployeesGridView Header
            employeesGridView.ColumnCount = 11;
            employeesGridView.Columns[0].Name = "ID";
            employeesGridView.Columns[1].Name = "Фамилия";
            employeesGridView.Columns[2].Name = "Имя";
            employeesGridView.Columns[3].Name = "Отчество";
            employeesGridView.Columns[4].Name = "Дата рождения";
            employeesGridView.Columns[5].Name = "Возраст";
            employeesGridView.Columns[6].Name = "Серия документа";
            employeesGridView.Columns[7].Name = "Номер документа";
            employeesGridView.Columns[8].Name = "Отдел";
            employeesGridView.Columns[9].Name = "Должность";
            employeesGridView.Columns[10].Name = "ID отдела";
            #endregion
            #endregion

            ShowDepartmentsInTreeView();
            ShowDepartmentsInListBox();
        }

        private TreeNode TreeViewRecursiveInitialization(Department curDepartment, DbSet<Department> departments)
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
            departmentListBox.Visible = false;
            departmentTreeView.Visible = true;
        }
        private void ListViewRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            departmentListBox.Visible = true;
            departmentTreeView.Visible = false;
        }

        private void DepartmentTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (departmentTreeView.SelectedNode == null)
                return;
            selectedDepartment = (Department)departmentTreeView.SelectedNode.Tag;
            ShowDepartmentDetails();
            ShowDepartmentEmployees();
        }
        private void DepartmentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (departmentListBox.SelectedIndex != -1)
            {
                selectedDepartment = (Department)departmentListBox.SelectedItem;
                ShowDepartmentDetails();
                ShowDepartmentEmployees();
            }
        }

        private void ShowDepartmentDetails()
        {
            string parentDepartmentName = "";
            if (selectedDepartment.ParentDepartmentID != null)
                // У каждого департамента, кроме фирмы, д.б. указан существующий отцовский департамент
                parentDepartmentName = dataBase.Departments.Find(selectedDepartment.ParentDepartmentID).Name;

            string[][] rows = new string[][]
            {
                new string[] { "ID", selectedDepartment.ID.ToString() },
                new string[] { "Название", selectedDepartment.Name },
                new string[] { "Код", selectedDepartment.Code },
                // new string[] { "Количество сотрудниов", selectedDepartment.Employees.Count.ToString() },
                new string[] { "Родительский отдел", parentDepartmentName },
                new string[] { "ID родительского отдела", selectedDepartment.ParentDepartmentID.ToString() }
            };

            departmentDetailsGridView.Rows.Clear();
            departmentDetailsGridView.ColumnCount = 2;

            foreach (string[] row in rows)
            {
                departmentDetailsGridView.Rows.Add(row);
            }
        }
        private void ShowDepartmentEmployees()
        {
            if (selectedDepartment == null)
                return;

            employeesGridView.Rows.Clear();

            foreach (Employee employee in selectedDepartment.Employees)
            {
                string[] row = { employee.ID.ToString(), employee.SurName, employee.FirstName, employee.Patronymic,
                                 employee.DateOfBirth.ToString("d", culture), Age(employee.DateOfBirth).ToString(),
                                 employee.DocSeries, employee.DocNumber, employee.Department.Name, employee.Position,
                                 employee.DepartmentID.ToString()};

                employeesGridView.Rows.Add(row);
            }
        }
        private void ShowDepartmentsInListBox()
        {
            departmentListBox.Items.Clear();
            foreach (var d in dataBase.Departments)
                departmentListBox.Items.Add(d);
            departmentListBox.Sorted = true;
        }
        private void ShowDepartmentsInTreeView()
        {
            departmentTreeView.Nodes.Clear();

            var rootDepartments = dataBase.Departments.Where(d => d.ParentDepartmentID == null);
            if (rootDepartments.Count() == 0)
                throw new Exception("Невозможно построение структуры предприятия. Отсутствует корневой Department.");

            foreach (Department d in rootDepartments)
                departmentTreeView.Nodes.Add(TreeViewRecursiveInitialization(d, dataBase.Departments));
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeForm addEmployeeForm = new EmployeeForm(dataBase.Departments, selectedDepartment, "Новый сотрудник");

            #region Validation
            bool correctValuesEntered = false;
            while (correctValuesEntered == false)
            {
                DialogResult dialogResult = addEmployeeForm.ShowDialog(this);

                if (dialogResult == DialogResult.Cancel)
                    return;
                correctValuesEntered = true;
                // Отсечение пробелов
                addEmployeeForm.surnameTextBox.Text = addEmployeeForm.surnameTextBox.Text.Trim();
                addEmployeeForm.firstNameTextBox.Text = addEmployeeForm.firstNameTextBox.Text.Trim();
                addEmployeeForm.patronymicTextBox.Text = addEmployeeForm.patronymicTextBox.Text.Trim();
                addEmployeeForm.docSeriesTextBox.Text = addEmployeeForm.docSeriesTextBox.Text.Trim();
                addEmployeeForm.docNumberTextBox.Text = addEmployeeForm.docNumberTextBox.Text.Trim();
                addEmployeeForm.positionTextBox.Text = addEmployeeForm.positionTextBox.Text.Trim();
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

            #region Set new Employee fields
            Employee newEmployee = new Employee();
            newEmployee.SurName = addEmployeeForm.surnameTextBox.Text;
            newEmployee.FirstName = addEmployeeForm.firstNameTextBox.Text;
            newEmployee.Patronymic = addEmployeeForm.patronymicTextBox.Text;
            newEmployee.DateOfBirth = addEmployeeForm.dateOfBirthDateTimePicker.Value.Date;
            newEmployee.DocSeries = addEmployeeForm.docSeriesTextBox.Text;
            newEmployee.DocNumber = addEmployeeForm.docNumberTextBox.Text;
            newEmployee.Position = addEmployeeForm.positionTextBox.Text;
            Department selectedInAddFormDepartment = (Department)addEmployeeForm.departmentComboBox.SelectedItem;
            newEmployee.DepartmentID = selectedInAddFormDepartment.ID;
            #endregion

            dataBase.Employees.Add(newEmployee);
            dataBase.SaveChanges();
            ShowDepartmentEmployees();
        }
        private void EditEmployeeButton_Click(object sender, EventArgs e)
        {
            #region Set new EmployeeForm child items
            EmployeeForm editEmployeeForm = new EmployeeForm(dataBase.Departments, selectedEmployee.Department, "Редактирование данных сотрудника");

            editEmployeeForm.surnameTextBox.Text = selectedEmployee.SurName;
            editEmployeeForm.firstNameTextBox.Text = selectedEmployee.FirstName;
            editEmployeeForm.patronymicTextBox.Text = selectedEmployee.Patronymic;
            editEmployeeForm.dateOfBirthDateTimePicker.Value = selectedEmployee.DateOfBirth;
            editEmployeeForm.docSeriesTextBox.Text = selectedEmployee.DocSeries;
            editEmployeeForm.docNumberTextBox.Text = selectedEmployee.DocNumber;
            editEmployeeForm.positionTextBox.Text = selectedEmployee.Position;
            #endregion

            #region Validation
            bool correctValuesEntered = false;
            while (correctValuesEntered == false)
            {
                DialogResult dialogResult = editEmployeeForm.ShowDialog(this);

                if (dialogResult == DialogResult.Cancel)
                    return;
                correctValuesEntered = true;
                // Отсечение пробелов
                editEmployeeForm.surnameTextBox.Text = editEmployeeForm.surnameTextBox.Text.Trim();
                editEmployeeForm.firstNameTextBox.Text = editEmployeeForm.firstNameTextBox.Text.Trim();
                editEmployeeForm.patronymicTextBox.Text = editEmployeeForm.patronymicTextBox.Text.Trim();
                editEmployeeForm.docSeriesTextBox.Text = editEmployeeForm.docSeriesTextBox.Text.Trim();
                editEmployeeForm.docNumberTextBox.Text = editEmployeeForm.docNumberTextBox.Text.Trim();
                editEmployeeForm.positionTextBox.Text = editEmployeeForm.positionTextBox.Text.Trim();
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

            #region Set Employee fields
            selectedEmployee.SurName = editEmployeeForm.surnameTextBox.Text;
            selectedEmployee.FirstName = editEmployeeForm.firstNameTextBox.Text;
            selectedEmployee.Patronymic = editEmployeeForm.patronymicTextBox.Text;
            selectedEmployee.DateOfBirth = editEmployeeForm.dateOfBirthDateTimePicker.Value.Date;
            selectedEmployee.DocSeries = editEmployeeForm.docSeriesTextBox.Text;
            selectedEmployee.DocNumber = editEmployeeForm.docNumberTextBox.Text;
            selectedEmployee.Position = editEmployeeForm.positionTextBox.Text;
            Department newEmployeeDepartment = (Department)editEmployeeForm.departmentComboBox.SelectedItem;
            selectedEmployee.DepartmentID = newEmployeeDepartment.ID;
            #endregion

            dataBase.SaveChanges();
            ShowDepartmentEmployees();
        }
        private void RemoveEmployeeButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (selectedEmployee.Patronymic != "")
                result = MessageBox.Show($"Удалить сотрудника {selectedEmployee.SurName} {selectedEmployee.FirstName} {selectedEmployee.Patronymic}?",
                                         "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            else
                result = MessageBox.Show($"Удалить сотрудника {selectedEmployee.SurName} {selectedEmployee.FirstName}?",
                                         "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
                return;

            dataBase.Employees.Remove(selectedEmployee);
            selectedEmployee = null;
            editEmployeeButton.Enabled = false;
            removeEmployeeButton.Enabled = false;
            dataBase.SaveChanges();
            ShowDepartmentEmployees();
        }

        private void AddDepartmentButton_Click(object sender, EventArgs e)
        {
            DepartmentForm addDepartmentForm = new DepartmentForm(dataBase.Departments, selectedDepartment, "Новый отдел");

            #region Validation
            bool correctValuesEntered = false;
            while (correctValuesEntered == false)
            {
                DialogResult dialogResult = addDepartmentForm.ShowDialog(this);

                if (dialogResult == DialogResult.Cancel)
                    return;
                correctValuesEntered = true;
                // Отсечение пробелов
                addDepartmentForm.nameTextBox.Text = addDepartmentForm.nameTextBox.Text.Trim();
                addDepartmentForm.codeTextBox.Text = addDepartmentForm.codeTextBox.Text.Trim();
                // Обязательные поля
                if (addDepartmentForm.nameTextBox.Text == "")
                {
                    MessageBox.Show("Поле \"Название\" должно быть заполнено!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correctValuesEntered = false;
                }
                // Длина строки
                if (addDepartmentForm.nameTextBox.Text.Length > 50)
                {
                    MessageBox.Show("Поле \"Название\" должно содержать не более 50 символов!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correctValuesEntered = false;
                }
                if (addDepartmentForm.codeTextBox.Text.Length > 10)
                {
                    MessageBox.Show("Поле \"Код\" должно содержать не более 10 символов!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correctValuesEntered = false;
                }
            }
            #endregion

            #region Set new Employee fields
            Department newDepartment = new Department();
            newDepartment.ID = Guid.NewGuid();
            newDepartment.Name = addDepartmentForm.nameTextBox.Text;
            newDepartment.Code = addDepartmentForm.codeTextBox.Text;
            Department selectedInAddFormDepartment = (Department)addDepartmentForm.departmentComboBox.SelectedItem;
            newDepartment.ParentDepartmentID = selectedInAddFormDepartment.ID;
            #endregion

            dataBase.Departments.Add(newDepartment);
            dataBase.SaveChanges();
            ShowDepartmentsInListBox();
            ShowDepartmentsInTreeView();
        }

        private void EmployeesGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (employeesGridView.SelectedRows.Count == 1)
            {
                int rowIndex = employeesGridView.SelectedRows[0].Index;
                decimal selectedEmployeeID = Convert.ToDecimal(employeesGridView[0, rowIndex].Value);
                selectedEmployee = dataBase.Employees.Find(selectedEmployeeID);

                editEmployeeButton.Enabled = true;
                removeEmployeeButton.Enabled = true;
            }
            else
            {
                editEmployeeButton.Enabled = false;
                removeEmployeeButton.Enabled = false;
                selectedEmployee = null;
            }
        }

        private int Age(DateTime dateOfBirth)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - dateOfBirth.Year;
            if (dateOfBirth > now.AddYears(-age)) age--;
            return age;
        }
    }
}
