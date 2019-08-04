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

namespace CompanyDBBrowser.App
{
    public partial class DepartmentForm : Form
    {
        public DepartmentForm(DbSet<Department> departments, Department selectedDepartment, string caption)
        {
            InitializeComponent();

            this.Text = caption;

            // Инициализация списка отделов
            foreach (Department d in departments)
            {
                departmentComboBox.Items.Add(d);
            }
            departmentComboBox.Sorted = true;

            // Выставление дефолтного значения отдела
            if (selectedDepartment != null)
                departmentComboBox.SelectedItem = selectedDepartment;
            else
                departmentComboBox.SelectedIndex = 0;
        }
    }
}
