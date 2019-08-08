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
using System.ComponentModel.DataAnnotations;

namespace CompanyDBBrowser.App
{
    public partial class DepartmentForm : Form, IValidatableObject
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

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            // Отсечение пробелов
            nameTextBox.Text = nameTextBox.Text.Trim();
            codeTextBox.Text = codeTextBox.Text.Trim();

            // Обязательные поля
            if (string.IsNullOrEmpty(nameTextBox.Text))
                errors.Add(new ValidationResult("Поле \"Название\" должно быть заполнено!"));

            // Длина строки
            if (nameTextBox.Text.Length > 50)
                errors.Add(new ValidationResult("Поле \"Название\" должно содержать не более 50 символов!"));
            if (codeTextBox.Text.Length > 10)
                errors.Add(new ValidationResult("Поле \"Код\" должно содержать не более 10 символов!"));

            return errors;
        }

        public bool RunValidaton()
        {
            var context = new ValidationContext(this);
            var results = new List<ValidationResult>();

            if (!Validator.TryValidateObject(this, context, results, true))
            {
                string messageBoxErrorMessage = "";
                foreach (ValidationResult r in results)
                    messageBoxErrorMessage += r.ErrorMessage + '\n';
                MessageBox.Show(messageBoxErrorMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void NullParentDepartmentIDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            departmentComboBox.Enabled = !nullParentDepartmentIDCheckBox.Checked;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (nullParentDepartmentIDCheckBox.Checked)
                departmentComboBox.SelectedItem = null;
        }
    }
}
