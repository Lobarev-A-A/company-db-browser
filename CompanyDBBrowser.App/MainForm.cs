using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyDBBrowser.App
{
    public partial class MainForm : Form
    {
        Model dataBase;

        public MainForm()
        {
            InitializeComponent();

            using(dataBase = new Model())
            {
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

                // Инициализация DepartmentTreeView
                DepartmentTreeView.Nodes.Add(TreeViewRecursiveInitialization(company.First(), departments));
                
                // Инициализация DepartmentListBox
                foreach (var d in departments)
                {
                    DepartmentListBox.Items.Add(d);
                }
            }

            // Установка начального состояния элементов формы
            TreeViewRadioButton.Checked = true;
            DepartmentListBox.Visible = false;
            DepartmentTreeView.Visible = true;
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
        }
        private void DepartmentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DepartmentListBox.SelectedIndex != -1)
            {
                Department selectedDepartment = (Department)DepartmentListBox.SelectedItem;
                ShowDepartmentDetails(selectedDepartment);
                ShowDepartmentEmployees(selectedDepartment);
            }
        }

        private void ShowDepartmentDetails(Department selectedDepartment)
        {
            using (dataBase = new Model())
            {
                dataBase.Departments.Attach(selectedDepartment);

                string parentDepartment = (dataBase.Departments.Find(selectedDepartment.ParentDepartmentID) == null) ? "" : dataBase.Departments.Find(selectedDepartment.ParentDepartmentID);
                string[][] rows = new string[][]
                {
                new string[] { "ID", selectedDepartment.ID.ToString() },
                new string[] { "Название", selectedDepartment.Name },
                new string[] { "Родительский отдел", parentDepartment },
                new string[] { "ID родительского отдела", selectedDepartment.ParentDepartmentID.ToString() }
                };

                DepartmentDetailsGridView.Rows.Clear();
                DepartmentDetailsGridView.ColumnCount = 2;

                foreach (string[] row in rows)
                {
                    DepartmentDetailsGridView.Rows.Add(row);
                }
            }
        }
        private void ShowDepartmentEmployees(Department selectedDepartment)
        {
            using (dataBase = new Model())
            {
                dataBase.Departments.Attach(selectedDepartment);
                EmployeesGridView.Rows.Clear();

                EmployeesGridView.ColumnCount = 11;
                EmployeesGridView.Columns[0].Name = "ID";
                EmployeesGridView.Columns[1].Name = "Фамилия";
                EmployeesGridView.Columns[2].Name = "Имя";
                EmployeesGridView.Columns[3].Name = "Отчество";
                EmployeesGridView.Columns[4].Name = "Дата рождения";
                EmployeesGridView.Columns[5].Name = "ID";
                EmployeesGridView.Columns[6].Name = "Серия документа";
                EmployeesGridView.Columns[7].Name = "Номер документа";
                EmployeesGridView.Columns[8].Name = "Отдел";
                EmployeesGridView.Columns[9].Name = "Должность";
                EmployeesGridView.Columns[10].Name = "ID отдела";

                foreach (Employee emp in selectedDepartment.Employees)
                {
                    string[] empRow0 = { "ID", emp.ID.ToString() };

                    EmployeesGridView.Rows.Add(empRow0);
                }
            }
        }
    }
}
