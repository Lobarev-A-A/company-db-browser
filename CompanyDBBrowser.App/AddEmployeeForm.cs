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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm(System.Data.Entity.DbSet<Department> departments)
        {
            InitializeComponent();

            // Инициализация списка отделов
            foreach (Department d in departments)
            {
                departmentComboBox.Items.Add(d);
            }
            departmentComboBox.Sorted = true;
            departmentComboBox.SelectedIndex = 0;
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
