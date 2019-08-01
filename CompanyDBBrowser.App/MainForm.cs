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
    }
}
