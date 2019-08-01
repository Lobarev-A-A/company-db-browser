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

        private void DepartmentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DepartmentListBox.SelectedIndex != -1)
            {
                Department selectedItem = (Department)DepartmentListBox.SelectedItem;

                string[] row0 = { "ID", selectedItem.ID.ToString() };
                string[] row1 = { "Name", selectedItem.Name };
                string[] row2 = { "ParentDepartmentID", selectedItem.ParentDepartmentID.ToString() };

                DepartmentDetailsGridView.Rows.Clear();
                DepartmentDetailsGridView.ColumnCount = 2;
                DepartmentDetailsGridView.Rows.Add(row0);
                DepartmentDetailsGridView.Rows.Add(row1);
                DepartmentDetailsGridView.Rows.Add(row2);
            }
        }

        private void DepartmentTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Department selectedNode = (Department)DepartmentTreeView.SelectedNode.Tag;

            string[] row0 = { "ID", selectedNode.ID.ToString() };
            string[] row1 = { "Name", selectedNode.Name };
            string[] row2 = { "ParentDepartmentID", selectedNode.ParentDepartmentID.ToString() };

            DepartmentDetailsGridView.Rows.Clear();
            DepartmentDetailsGridView.ColumnCount = 2;
            DepartmentDetailsGridView.Rows.Add(row0);
            DepartmentDetailsGridView.Rows.Add(row1);
            DepartmentDetailsGridView.Rows.Add(row2);
        }
    }
}
