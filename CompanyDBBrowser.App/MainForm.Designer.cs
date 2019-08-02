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
            this.DepartmentListBox = new System.Windows.Forms.ListBox();
            this.ListViewRadioButton = new System.Windows.Forms.RadioButton();
            this.TreeViewRadioButton = new System.Windows.Forms.RadioButton();
            this.EmployeesGridView = new System.Windows.Forms.DataGridView();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.EditEmployeeButton = new System.Windows.Forms.Button();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.EditDepartmentButton = new System.Windows.Forms.Button();
            this.AddDepartmentButton = new System.Windows.Forms.Button();
            this.DeleteDepartmentButton = new System.Windows.Forms.Button();
            this.DepartmentDetailsGridView = new System.Windows.Forms.DataGridView();
            this.DepartmentDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.EmployeesGroupBox = new System.Windows.Forms.GroupBox();
            this.DepartmentsViewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentDetailsGridView)).BeginInit();
            this.DepartmentDetailsGroupBox.SuspendLayout();
            this.EmployeesGroupBox.SuspendLayout();
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
            this.DepartmentTreeView.Size = new System.Drawing.Size(401, 356);
            this.DepartmentTreeView.TabIndex = 1;
            this.DepartmentTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.DepartmentTreeView_NodeMouseDoubleClick);
            // 
            // DepartmentsViewGroupBox
            // 
            this.DepartmentsViewGroupBox.Controls.Add(this.DepartmentListBox);
            this.DepartmentsViewGroupBox.Controls.Add(this.ListViewRadioButton);
            this.DepartmentsViewGroupBox.Controls.Add(this.TreeViewRadioButton);
            this.DepartmentsViewGroupBox.Controls.Add(this.DepartmentTreeView);
            this.DepartmentsViewGroupBox.Location = new System.Drawing.Point(10, 33);
            this.DepartmentsViewGroupBox.Name = "DepartmentsViewGroupBox";
            this.DepartmentsViewGroupBox.Size = new System.Drawing.Size(403, 412);
            this.DepartmentsViewGroupBox.TabIndex = 2;
            this.DepartmentsViewGroupBox.TabStop = false;
            this.DepartmentsViewGroupBox.Text = "Отделы";
            // 
            // DepartmentListBox
            // 
            this.DepartmentListBox.FormattingEnabled = true;
            this.DepartmentListBox.ItemHeight = 16;
            this.DepartmentListBox.Location = new System.Drawing.Point(0, 21);
            this.DepartmentListBox.Name = "DepartmentListBox";
            this.DepartmentListBox.Size = new System.Drawing.Size(401, 356);
            this.DepartmentListBox.TabIndex = 12;
            this.DepartmentListBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentListBox_SelectedIndexChanged);
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
            this.EmployeesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.EmployeesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EmployeesGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.EmployeesGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EmployeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesGridView.Location = new System.Drawing.Point(0, 21);
            this.EmployeesGridView.Name = "EmployeesGridView";
            this.EmployeesGridView.ReadOnly = true;
            this.EmployeesGridView.RowHeadersVisible = false;
            this.EmployeesGridView.RowHeadersWidth = 51;
            this.EmployeesGridView.RowTemplate.Height = 24;
            this.EmployeesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeesGridView.Size = new System.Drawing.Size(931, 575);
            this.EmployeesGridView.TabIndex = 3;
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(587, 603);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(100, 49);
            this.AddEmployeeButton.TabIndex = 9;
            this.AddEmployeeButton.Text = "Добавить сотрудника";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // EditEmployeeButton
            // 
            this.EditEmployeeButton.Location = new System.Drawing.Point(693, 603);
            this.EditEmployeeButton.Name = "EditEmployeeButton";
            this.EditEmployeeButton.Size = new System.Drawing.Size(128, 49);
            this.EditEmployeeButton.TabIndex = 10;
            this.EditEmployeeButton.Text = "Редактировать сотрудника";
            this.EditEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(827, 602);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(97, 50);
            this.DeleteEmployeeButton.TabIndex = 11;
            this.DeleteEmployeeButton.Text = "Удалить сотрудника";
            this.DeleteEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // EditDepartmentButton
            // 
            this.EditDepartmentButton.Location = new System.Drawing.Point(138, 191);
            this.EditDepartmentButton.Name = "EditDepartmentButton";
            this.EditDepartmentButton.Size = new System.Drawing.Size(127, 49);
            this.EditDepartmentButton.TabIndex = 7;
            this.EditDepartmentButton.Text = "Редактировать отдел";
            this.EditDepartmentButton.UseVisualStyleBackColor = true;
            // 
            // AddDepartmentButton
            // 
            this.AddDepartmentButton.Location = new System.Drawing.Point(13, 190);
            this.AddDepartmentButton.Name = "AddDepartmentButton";
            this.AddDepartmentButton.Size = new System.Drawing.Size(94, 50);
            this.AddDepartmentButton.TabIndex = 6;
            this.AddDepartmentButton.Text = "Добавить отдел";
            this.AddDepartmentButton.UseVisualStyleBackColor = true;
            // 
            // DeleteDepartmentButton
            // 
            this.DeleteDepartmentButton.Location = new System.Drawing.Point(298, 191);
            this.DeleteDepartmentButton.Name = "DeleteDepartmentButton";
            this.DeleteDepartmentButton.Size = new System.Drawing.Size(90, 49);
            this.DeleteDepartmentButton.TabIndex = 8;
            this.DeleteDepartmentButton.Text = "Удалить отдел";
            this.DeleteDepartmentButton.UseVisualStyleBackColor = true;
            // 
            // DepartmentDetailsGridView
            // 
            this.DepartmentDetailsGridView.AllowUserToAddRows = false;
            this.DepartmentDetailsGridView.AllowUserToDeleteRows = false;
            this.DepartmentDetailsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DepartmentDetailsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DepartmentDetailsGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DepartmentDetailsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DepartmentDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentDetailsGridView.ColumnHeadersVisible = false;
            this.DepartmentDetailsGridView.Location = new System.Drawing.Point(0, 21);
            this.DepartmentDetailsGridView.Name = "DepartmentDetailsGridView";
            this.DepartmentDetailsGridView.ReadOnly = true;
            this.DepartmentDetailsGridView.RowHeadersVisible = false;
            this.DepartmentDetailsGridView.RowHeadersWidth = 51;
            this.DepartmentDetailsGridView.RowTemplate.Height = 24;
            this.DepartmentDetailsGridView.Size = new System.Drawing.Size(401, 163);
            this.DepartmentDetailsGridView.TabIndex = 5;
            // 
            // DepartmentDetailsGroupBox
            // 
            this.DepartmentDetailsGroupBox.Controls.Add(this.DepartmentDetailsGridView);
            this.DepartmentDetailsGroupBox.Controls.Add(this.EditDepartmentButton);
            this.DepartmentDetailsGroupBox.Controls.Add(this.DeleteDepartmentButton);
            this.DepartmentDetailsGroupBox.Controls.Add(this.AddDepartmentButton);
            this.DepartmentDetailsGroupBox.Location = new System.Drawing.Point(10, 445);
            this.DepartmentDetailsGroupBox.Name = "DepartmentDetailsGroupBox";
            this.DepartmentDetailsGroupBox.Size = new System.Drawing.Size(403, 249);
            this.DepartmentDetailsGroupBox.TabIndex = 12;
            this.DepartmentDetailsGroupBox.TabStop = false;
            this.DepartmentDetailsGroupBox.Text = "Информация об отделе";
            // 
            // EmployeesGroupBox
            // 
            this.EmployeesGroupBox.Controls.Add(this.AddEmployeeButton);
            this.EmployeesGroupBox.Controls.Add(this.EditEmployeeButton);
            this.EmployeesGroupBox.Controls.Add(this.EmployeesGridView);
            this.EmployeesGroupBox.Controls.Add(this.DeleteEmployeeButton);
            this.EmployeesGroupBox.Location = new System.Drawing.Point(437, 33);
            this.EmployeesGroupBox.Name = "EmployeesGroupBox";
            this.EmployeesGroupBox.Size = new System.Drawing.Size(933, 661);
            this.EmployeesGroupBox.TabIndex = 13;
            this.EmployeesGroupBox.TabStop = false;
            this.EmployeesGroupBox.Text = "Сотрудники отдела";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 699);
            this.Controls.Add(this.EmployeesGroupBox);
            this.Controls.Add(this.DepartmentDetailsGroupBox);
            this.Controls.Add(this.DepartmentsViewGroupBox);
            this.Controls.Add(this.CompanyNameLabel);
            this.Name = "MainForm";
            this.Text = "CompanyDBBrowser";
            this.DepartmentsViewGroupBox.ResumeLayout(false);
            this.DepartmentsViewGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentDetailsGridView)).EndInit();
            this.DepartmentDetailsGroupBox.ResumeLayout(false);
            this.EmployeesGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button EditEmployeeButton;
        private System.Windows.Forms.Button DeleteEmployeeButton;
        private System.Windows.Forms.ListBox DepartmentListBox;
        private System.Windows.Forms.Button EditDepartmentButton;
        private System.Windows.Forms.Button AddDepartmentButton;
        private System.Windows.Forms.Button DeleteDepartmentButton;
        private System.Windows.Forms.DataGridView DepartmentDetailsGridView;
        private System.Windows.Forms.GroupBox DepartmentDetailsGroupBox;
        private System.Windows.Forms.GroupBox EmployeesGroupBox;
    }
}

