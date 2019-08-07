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
    public partial class EmployeeForm : Form, IValidatableObject
    {
        public EmployeeForm(DbSet<Department> departments, Department selectedDepartment, string caption)
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
            surnameTextBox.Text = surnameTextBox.Text.Trim();
            firstNameTextBox.Text = firstNameTextBox.Text.Trim();
            patronymicTextBox.Text = patronymicTextBox.Text.Trim();
            docSeriesTextBox.Text = docSeriesTextBox.Text.Trim();
            docNumberTextBox.Text = docNumberTextBox.Text.Trim();
            positionTextBox.Text = positionTextBox.Text.Trim();

            // Обязательные поля
            if (string.IsNullOrEmpty(surnameTextBox.Text))
                errors.Add(new ValidationResult("Поле \"Фамилия\" должно быть заполнено!"));
            if (string.IsNullOrEmpty(firstNameTextBox.Text))
                errors.Add(new ValidationResult("Поле \"Имя\" должно быть заполнено!"));
            if (string.IsNullOrEmpty(positionTextBox.Text))
                errors.Add(new ValidationResult("Поле \"Должность\" должно быть заполнено!"));

            // Длина строки
            if (surnameTextBox.Text.Length > 50)
                errors.Add(new ValidationResult("Поле \"Фамилия\" должно содержать не более 50 символов!"));
            if (firstNameTextBox.Text.Length > 50)
                errors.Add(new ValidationResult("Поле \"Имя\" должно содержать не более 50 символов!"));
            if (patronymicTextBox.Text.Length > 50)
                errors.Add(new ValidationResult("Поле \"Отчество\" должно содержать не более 50 символов!"));
            if (docSeriesTextBox.Text.Length > 4)
                errors.Add(new ValidationResult("Поле \"Серия документа\" должно содержать не более 4 символов!"));
            if (docNumberTextBox.Text.Length > 6)
                errors.Add(new ValidationResult("Поле \"Номер документа\" должно содержать не более 6 символов!"));
            if (positionTextBox.Text.Length > 50)
                errors.Add(new ValidationResult("Поле \"Должность\" должно содержать не более 50 символов!"));

            return errors;
        }

        public bool RunValidation()
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
    }
}
