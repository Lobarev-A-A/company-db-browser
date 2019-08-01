namespace CompanyDBBrowser.App
{
    partial class MainForm
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
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.DepartmentTreeView = new System.Windows.Forms.TreeView();
            this.DepartmentsViewGroupBox = new System.Windows.Forms.GroupBox();
            this.ListViewRadioButton = new System.Windows.Forms.RadioButton();
            this.TreeViewRadioButton = new System.Windows.Forms.RadioButton();
            this.EmployeesGridView = new System.Windows.Forms.DataGridView();
            this.DepartmentInformationLabel = new System.Windows.Forms.Label();
            this.DepartmentDetailsGridView = new System.Windows.Forms.DataGridView();
            this.AddDepartmentButton = new System.Windows.Forms.Button();
            this.EditDepartmentButton = new System.Windows.Forms.Button();
            this.DeleteDepartmentButton = new System.Windows.Forms.Button();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.EditEmployeeButton = new System.Windows.Forms.Button();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.DepartmentListBox = new System.Windows.Forms.ListBox();
            this.DepartmentsViewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentDetailsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyNameLabel.Location = new System.Drawing.Point(10, 8);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(149, 25);
            this.CompanyNameLabel.TabIndex = 0;
            this.CompanyNameLabel.Text = "CompanyName";
            // 
            // DepartmentTreeView
            // 
            this.DepartmentTreeView.Location = new System.Drawing.Point(0, 21);
            this.DepartmentTreeView.Name = "DepartmentTreeView";
            this.DepartmentTreeView.Size = new System.Drawing.Size(348, 356);
            this.DepartmentTreeView.TabIndex = 1;
            // 
            // DepartmentsViewGroupBox
            // 
            this.DepartmentsViewGroupBox.Controls.Add(this.DepartmentListBox);
            this.DepartmentsViewGroupBox.Controls.Add(this.ListViewRadioButton);
            this.DepartmentsViewGroupBox.Controls.Add(this.TreeViewRadioButton);
            this.DepartmentsViewGroupBox.Controls.Add(this.DepartmentTreeView);
            this.DepartmentsViewGroupBox.Location = new System.Drawing.Point(10, 33);
            this.DepartmentsViewGroupBox.Name = "DepartmentsViewGroupBox";
            this.DepartmentsViewGroupBox.Size = new System.Drawing.Size(350, 412);
            this.DepartmentsViewGroupBox.TabIndex = 2;
            this.DepartmentsViewGroupBox.TabStop = false;
            this.DepartmentsViewGroupBox.Text = "Отделы";
            // 
            // ListViewRadioButton
            // 
            this.ListViewRadioButton.AutoSize = true;
            this.ListViewRadioButton.Location = new System.Drawing.Point(90, 383);
            this.ListViewRadioButton.Name = "ListViewRadioButton";
            this.ListViewRadioButton.Size = new System.Drawing.Size(76, 21);
            this.ListViewRadioButton.TabIndex = 1;
            this.ListViewRadioButton.TabStop = true;
            this.ListViewRadioButton.Text = "Список";
            this.ListViewRadioButton.UseVisualStyleBackColor = true;
            this.ListViewRadioButton.CheckedChanged += new System.EventHandler(this.ListViewRadioButton_CheckedChanged);
            // 
            // TreeViewRadioButton
            // 
            this.TreeViewRadioButton.AutoSize = true;
            this.TreeViewRadioButton.Location = new System.Drawing.Point(11, 383);
            this.TreeViewRadioButton.Name = "TreeViewRadioButton";
            this.TreeViewRadioButton.Size = new System.Drawing.Size(79, 21);
            this.TreeViewRadioButton.TabIndex = 0;
            this.TreeViewRadioButton.TabStop = true;
            this.TreeViewRadioButton.Text = "Дерево";
            this.TreeViewRadioButton.UseVisualStyleBackColor = true;
            this.TreeViewRadioButton.CheckedChanged += new System.EventHandler(this.TreeViewRadioButton_CheckedChanged);
            // 
            // EmployeesGridView
            // 
            this.EmployeesGridView.AllowUserToAddRows = false;
            this.EmployeesGridView.AllowUserToDeleteRows = false;
            this.EmployeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesGridView.Location = new System.Drawing.Point(424, 33);
            this.EmployeesGridView.Name = "EmployeesGridView";
            this.EmployeesGridView.ReadOnly = true;
            this.EmployeesGridView.RowHeadersWidth = 51;
            this.EmployeesGridView.RowTemplate.Height = 24;
            this.EmployeesGridView.Size = new System.Drawing.Size(532, 584);
            this.EmployeesGridView.TabIndex = 3;
            // 
            // DepartmentInformationLabel
            // 
            this.DepartmentInformationLabel.AutoSize = true;
            this.DepartmentInformationLabel.Location = new System.Drawing.Point(12, 460);
            this.DepartmentInformationLabel.Name = "DepartmentInformationLabel";
            this.DepartmentInformationLabel.Size = new System.Drawing.Size(152, 17);
            this.DepartmentInformationLabel.TabIndex = 4;
            this.DepartmentInformationLabel.Text = "DepartmentInformation";
            // 
            // DepartmentDetailsGridView
            // 
            this.DepartmentDetailsGridView.AllowUserToAddRows = false;
            this.DepartmentDetailsGridView.AllowUserToDeleteRows = false;
            this.DepartmentDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentDetailsGridView.Location = new System.Drawing.Point(15, 490);
            this.DepartmentDetailsGridView.Name = "DepartmentDetailsGridView";
            this.DepartmentDetailsGridView.ReadOnly = true;
            this.DepartmentDetailsGridView.RowHeadersWidth = 51;
            this.DepartmentDetailsGridView.RowTemplate.Height = 24;
            this.DepartmentDetailsGridView.Size = new System.Drawing.Size(300, 135);
            this.DepartmentDetailsGridView.TabIndex = 5;
            // 
            // AddDepartmentButton
            // 
            this.AddDepartmentButton.Location = new System.Drawing.Point(15, 631);
            this.AddDepartmentButton.Name = "AddDepartmentButton";
            this.AddDepartmentButton.Size = new System.Drawing.Size(80, 50);
            this.AddDepartmentButton.TabIndex = 6;
            this.AddDepartmentButton.Text = "Добавить отдел";
            this.AddDepartmentButton.UseVisualStyleBackColor = true;
            // 
            // EditDepartmentButton
            // 
            this.EditDepartmentButton.Location = new System.Drawing.Point(102, 632);
            this.EditDepartmentButton.Name = "EditDepartmentButton";
            this.EditDepartmentButton.Size = new System.Drawing.Size(116, 49);
            this.EditDepartmentButton.TabIndex = 7;
            this.EditDepartmentButton.Text = "Редактировать отдел";
            this.EditDepartmentButton.UseVisualStyleBackColor = true;
            // 
            // DeleteDepartmentButton
            // 
            this.DeleteDepartmentButton.Location = new System.Drawing.Point(225, 632);
            this.DeleteDepartmentButton.Name = "DeleteDepartmentButton";
            this.DeleteDepartmentButton.Size = new System.Drawing.Size(90, 49);
            this.DeleteDepartmentButton.TabIndex = 8;
            this.DeleteDepartmentButton.Text = "Удалить отдел";
            this.DeleteDepartmentButton.UseVisualStyleBackColor = true;
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(607, 632);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(95, 49);
            this.AddEmployeeButton.TabIndex = 9;
            this.AddEmployeeButton.Text = "Добавить сотрудника";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // EditEmployeeButton
            // 
            this.EditEmployeeButton.Location = new System.Drawing.Point(709, 632);
            this.EditEmployeeButton.Name = "EditEmployeeButton";
            this.EditEmployeeButton.Size = new System.Drawing.Size(128, 49);
            this.EditEmployeeButton.TabIndex = 10;
            this.EditEmployeeButton.Text = "Редактировать сотрудника";
            this.EditEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(843, 631);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(97, 50);
            this.DeleteEmployeeButton.TabIndex = 11;
            this.DeleteEmployeeButton.Text = "Удалить сотрудника";
            this.DeleteEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // DepartmentListBox
            // 
            this.DepartmentListBox.FormattingEnabled = true;
            this.DepartmentListBox.ItemHeight = 16;
            this.DepartmentListBox.Location = new System.Drawing.Point(0, 21);
            this.DepartmentListBox.Name = "DepartmentListBox";
            this.DepartmentListBox.Size = new System.Drawing.Size(348, 356);
            this.DepartmentListBox.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 703);
            this.Controls.Add(this.DeleteEmployeeButton);
            this.Controls.Add(this.EditEmployeeButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.DeleteDepartmentButton);
            this.Controls.Add(this.EditDepartmentButton);
            this.Controls.Add(this.AddDepartmentButton);
            this.Controls.Add(this.DepartmentDetailsGridView);
            this.Controls.Add(this.DepartmentInformationLabel);
            this.Controls.Add(this.EmployeesGridView);
            this.Controls.Add(this.DepartmentsViewGroupBox);
            this.Controls.Add(this.CompanyNameLabel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.DepartmentsViewGroupBox.ResumeLayout(false);
            this.DepartmentsViewGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentDetailsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.TreeView DepartmentTreeView;
        private System.Windows.Forms.GroupBox DepartmentsViewGroupBox;
        private System.Windows.Forms.RadioButton ListViewRadioButton;
        private System.Windows.Forms.RadioButton TreeViewRadioButton;
        private System.Windows.Forms.DataGridView EmployeesGridView;
        private System.Windows.Forms.Label DepartmentInformationLabel;
        private System.Windows.Forms.DataGridView DepartmentDetailsGridView;
        private System.Windows.Forms.Button AddDepartmentButton;
        private System.Windows.Forms.Button EditDepartmentButton;
        private System.Windows.Forms.Button DeleteDepartmentButton;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button EditEmployeeButton;
        private System.Windows.Forms.Button DeleteEmployeeButton;
        private System.Windows.Forms.ListBox DepartmentListBox;
    }
}

