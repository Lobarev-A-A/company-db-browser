namespace CompanyDBBrowser.App
{
    partial class DepartmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fieldLengthAttentionLabel2 = new System.Windows.Forms.Label();
            this.fieldLengthAttentionLabel1 = new System.Windows.Forms.Label();
            this.obligatoryFieldMarkerLabel1 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.markedFieldsAttentionLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.parentDepartmentLabel = new System.Windows.Forms.Label();
            this.nullParentDepartmentIDCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // fieldLengthAttentionLabel2
            // 
            this.fieldLengthAttentionLabel2.AutoSize = true;
            this.fieldLengthAttentionLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldLengthAttentionLabel2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.fieldLengthAttentionLabel2.Location = new System.Drawing.Point(61, 75);
            this.fieldLengthAttentionLabel2.Name = "fieldLengthAttentionLabel2";
            this.fieldLengthAttentionLabel2.Size = new System.Drawing.Size(136, 15);
            this.fieldLengthAttentionLabel2.TabIndex = 33;
            this.fieldLengthAttentionLabel2.Text = "не более 10 символов";
            // 
            // fieldLengthAttentionLabel1
            // 
            this.fieldLengthAttentionLabel1.AutoSize = true;
            this.fieldLengthAttentionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldLengthAttentionLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.fieldLengthAttentionLabel1.Location = new System.Drawing.Point(100, 31);
            this.fieldLengthAttentionLabel1.Name = "fieldLengthAttentionLabel1";
            this.fieldLengthAttentionLabel1.Size = new System.Drawing.Size(136, 15);
            this.fieldLengthAttentionLabel1.TabIndex = 32;
            this.fieldLengthAttentionLabel1.Text = "не более 50 символов";
            // 
            // obligatoryFieldMarkerLabel1
            // 
            this.obligatoryFieldMarkerLabel1.AutoSize = true;
            this.obligatoryFieldMarkerLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.obligatoryFieldMarkerLabel1.Location = new System.Drawing.Point(629, 26);
            this.obligatoryFieldMarkerLabel1.Name = "obligatoryFieldMarkerLabel1";
            this.obligatoryFieldMarkerLabel1.Size = new System.Drawing.Size(20, 25);
            this.obligatoryFieldMarkerLabel1.TabIndex = 31;
            this.obligatoryFieldMarkerLabel1.Text = "*";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(318, 71);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(309, 22);
            this.codeTextBox.TabIndex = 30;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(318, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(309, 22);
            this.nameTextBox.TabIndex = 29;
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(20, 74);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(33, 17);
            this.codeLabel.TabIndex = 28;
            this.codeLabel.Text = "Код";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(20, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(72, 17);
            this.nameLabel.TabIndex = 27;
            this.nameLabel.Text = "Название";
            // 
            // markedFieldsAttentionLabel
            // 
            this.markedFieldsAttentionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markedFieldsAttentionLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.markedFieldsAttentionLabel.Location = new System.Drawing.Point(20, 153);
            this.markedFieldsAttentionLabel.Name = "markedFieldsAttentionLabel";
            this.markedFieldsAttentionLabel.Size = new System.Drawing.Size(447, 25);
            this.markedFieldsAttentionLabel.TabIndex = 36;
            this.markedFieldsAttentionLabel.Text = "Поля, отмеченные звёздочкой (*), обязательны для заполнения";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(534, 186);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 28);
            this.cancelButton.TabIndex = 35;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmButton.Location = new System.Drawing.Point(437, 186);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(93, 28);
            this.confirmButton.TabIndex = 34;
            this.confirmButton.Text = "ОК";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(318, 115);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(309, 24);
            this.departmentComboBox.TabIndex = 38;
            // 
            // parentDepartmentLabel
            // 
            this.parentDepartmentLabel.AutoSize = true;
            this.parentDepartmentLabel.Location = new System.Drawing.Point(20, 119);
            this.parentDepartmentLabel.Name = "parentDepartmentLabel";
            this.parentDepartmentLabel.Size = new System.Drawing.Size(144, 17);
            this.parentDepartmentLabel.TabIndex = 37;
            this.parentDepartmentLabel.Text = "Родительский отдел";
            // 
            // nullParentDepartmentIDCheckBox
            // 
            this.nullParentDepartmentIDCheckBox.AutoSize = true;
            this.nullParentDepartmentIDCheckBox.Location = new System.Drawing.Point(172, 119);
            this.nullParentDepartmentIDCheckBox.Name = "nullParentDepartmentIDCheckBox";
            this.nullParentDepartmentIDCheckBox.Size = new System.Drawing.Size(120, 21);
            this.nullParentDepartmentIDCheckBox.TabIndex = 40;
            this.nullParentDepartmentIDCheckBox.Text = "Не указывать";
            this.nullParentDepartmentIDCheckBox.UseVisualStyleBackColor = true;
            this.nullParentDepartmentIDCheckBox.CheckedChanged += new System.EventHandler(this.NullParentDepartmentIDCheckBox_CheckedChanged);
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 232);
            this.Controls.Add(this.nullParentDepartmentIDCheckBox);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.parentDepartmentLabel);
            this.Controls.Add(this.markedFieldsAttentionLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.fieldLengthAttentionLabel2);
            this.Controls.Add(this.fieldLengthAttentionLabel1);
            this.Controls.Add(this.obligatoryFieldMarkerLabel1);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DepartmentForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fieldLengthAttentionLabel2;
        private System.Windows.Forms.Label fieldLengthAttentionLabel1;
        private System.Windows.Forms.Label obligatoryFieldMarkerLabel1;
        protected internal System.Windows.Forms.TextBox codeTextBox;
        protected internal System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label markedFieldsAttentionLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        protected internal System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label parentDepartmentLabel;
        private System.Windows.Forms.CheckBox nullParentDepartmentIDCheckBox;
    }
}