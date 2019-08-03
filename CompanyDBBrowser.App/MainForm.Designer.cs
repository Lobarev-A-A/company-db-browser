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
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.departmentTreeView = new System.Windows.Forms.TreeView();
            this.departmentsViewGroupBox = new System.Windows.Forms.GroupBox();
            this.departmentListBox = new System.Windows.Forms.ListBox();
            this.listViewRadioButton = new System.Windows.Forms.RadioButton();
            this.treeViewRadioButton = new System.Windows.Forms.RadioButton();
            this.employeesGridView = new System.Windows.Forms.DataGridView();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.editEmployeeButton = new System.Windows.Forms.Button();
            this.removeEmployeeButton = new System.Windows.Forms.Button();
            this.editDepartmentButton = new System.Windows.Forms.Button();
            this.addDepartmentButton = new System.Windows.Forms.Button();
            this.removeDepartmentButton = new System.Windows.Forms.Button();
            this.departmentDetailsGridView = new System.Windows.Forms.DataGridView();
            this.departmentDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.employeesGroupBox = new System.Windows.Forms.GroupBox();
            this.departmentsViewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDetailsGridView)).BeginInit();
            this.departmentDetailsGroupBox.SuspendLayout();
            this.employeesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyNameLabel.Location = new System.Drawing.Point(10, 8);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(149, 25);
            this.companyNameLabel.TabIndex = 0;
            this.companyNameLabel.Text = "CompanyName";
            // 
            // departmentTreeView
            // 
            this.departmentTreeView.Location = new System.Drawing.Point(0, 21);
            this.departmentTreeView.Name = "departmentTreeView";
            this.departmentTreeView.Size = new System.Drawing.Size(401, 356);
            this.departmentTreeView.TabIndex = 1;
            this.departmentTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.DepartmentTreeView_NodeMouseDoubleClick);
            // 
            // departmentsViewGroupBox
            // 
            this.departmentsViewGroupBox.Controls.Add(this.departmentListBox);
            this.departmentsViewGroupBox.Controls.Add(this.listViewRadioButton);
            this.departmentsViewGroupBox.Controls.Add(this.treeViewRadioButton);
            this.departmentsViewGroupBox.Controls.Add(this.departmentTreeView);
            this.departmentsViewGroupBox.Location = new System.Drawing.Point(10, 33);
            this.departmentsViewGroupBox.Name = "departmentsViewGroupBox";
            this.departmentsViewGroupBox.Size = new System.Drawing.Size(403, 412);
            this.departmentsViewGroupBox.TabIndex = 2;
            this.departmentsViewGroupBox.TabStop = false;
            this.departmentsViewGroupBox.Text = "Отделы";
            // 
            // departmentListBox
            // 
            this.departmentListBox.FormattingEnabled = true;
            this.departmentListBox.ItemHeight = 16;
            this.departmentListBox.Location = new System.Drawing.Point(0, 21);
            this.departmentListBox.Name = "departmentListBox";
            this.departmentListBox.Size = new System.Drawing.Size(401, 356);
            this.departmentListBox.TabIndex = 12;
            this.departmentListBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentListBox_SelectedIndexChanged);
            // 
            // listViewRadioButton
            // 
            this.listViewRadioButton.AutoSize = true;
            this.listViewRadioButton.Location = new System.Drawing.Point(90, 383);
            this.listViewRadioButton.Name = "listViewRadioButton";
            this.listViewRadioButton.Size = new System.Drawing.Size(76, 21);
            this.listViewRadioButton.TabIndex = 1;
            this.listViewRadioButton.TabStop = true;
            this.listViewRadioButton.Text = "Список";
            this.listViewRadioButton.UseVisualStyleBackColor = true;
            this.listViewRadioButton.CheckedChanged += new System.EventHandler(this.ListViewRadioButton_CheckedChanged);
            // 
            // treeViewRadioButton
            // 
            this.treeViewRadioButton.AutoSize = true;
            this.treeViewRadioButton.Location = new System.Drawing.Point(11, 383);
            this.treeViewRadioButton.Name = "treeViewRadioButton";
            this.treeViewRadioButton.Size = new System.Drawing.Size(79, 21);
            this.treeViewRadioButton.TabIndex = 0;
            this.treeViewRadioButton.TabStop = true;
            this.treeViewRadioButton.Text = "Дерево";
            this.treeViewRadioButton.UseVisualStyleBackColor = true;
            this.treeViewRadioButton.CheckedChanged += new System.EventHandler(this.TreeViewRadioButton_CheckedChanged);
            // 
            // employeesGridView
            // 
            this.employeesGridView.AllowUserToAddRows = false;
            this.employeesGridView.AllowUserToDeleteRows = false;
            this.employeesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.employeesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.employeesGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.employeesGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.employeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesGridView.Location = new System.Drawing.Point(0, 21);
            this.employeesGridView.Name = "employeesGridView";
            this.employeesGridView.ReadOnly = true;
            this.employeesGridView.RowHeadersVisible = false;
            this.employeesGridView.RowHeadersWidth = 51;
            this.employeesGridView.RowTemplate.Height = 24;
            this.employeesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesGridView.Size = new System.Drawing.Size(931, 575);
            this.employeesGridView.TabIndex = 3;
            this.employeesGridView.SelectionChanged += new System.EventHandler(this.EmployeesGridView_SelectionChanged);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(587, 603);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(100, 49);
            this.addEmployeeButton.TabIndex = 9;
            this.addEmployeeButton.Text = "Добавить сотрудника";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // editEmployeeButton
            // 
            this.editEmployeeButton.Location = new System.Drawing.Point(693, 603);
            this.editEmployeeButton.Name = "editEmployeeButton";
            this.editEmployeeButton.Size = new System.Drawing.Size(128, 49);
            this.editEmployeeButton.TabIndex = 10;
            this.editEmployeeButton.Text = "Редактировать сотрудника";
            this.editEmployeeButton.UseVisualStyleBackColor = true;
            this.editEmployeeButton.Click += new System.EventHandler(this.EditEmployeeButton_Click);
            // 
            // removeEmployeeButton
            // 
            this.removeEmployeeButton.Location = new System.Drawing.Point(827, 602);
            this.removeEmployeeButton.Name = "removeEmployeeButton";
            this.removeEmployeeButton.Size = new System.Drawing.Size(97, 50);
            this.removeEmployeeButton.TabIndex = 11;
            this.removeEmployeeButton.Text = "Удалить сотрудника";
            this.removeEmployeeButton.UseVisualStyleBackColor = true;
            this.removeEmployeeButton.Click += new System.EventHandler(this.RemoveEmployeeButton_Click);
            // 
            // editDepartmentButton
            // 
            this.editDepartmentButton.Location = new System.Drawing.Point(138, 191);
            this.editDepartmentButton.Name = "editDepartmentButton";
            this.editDepartmentButton.Size = new System.Drawing.Size(127, 49);
            this.editDepartmentButton.TabIndex = 7;
            this.editDepartmentButton.Text = "Редактировать отдел";
            this.editDepartmentButton.UseVisualStyleBackColor = true;
            // 
            // addDepartmentButton
            // 
            this.addDepartmentButton.Location = new System.Drawing.Point(13, 190);
            this.addDepartmentButton.Name = "addDepartmentButton";
            this.addDepartmentButton.Size = new System.Drawing.Size(94, 50);
            this.addDepartmentButton.TabIndex = 6;
            this.addDepartmentButton.Text = "Добавить отдел";
            this.addDepartmentButton.UseVisualStyleBackColor = true;
            // 
            // removeDepartmentButton
            // 
            this.removeDepartmentButton.Location = new System.Drawing.Point(298, 191);
            this.removeDepartmentButton.Name = "removeDepartmentButton";
            this.removeDepartmentButton.Size = new System.Drawing.Size(90, 49);
            this.removeDepartmentButton.TabIndex = 8;
            this.removeDepartmentButton.Text = "Удалить отдел";
            this.removeDepartmentButton.UseVisualStyleBackColor = true;
            // 
            // departmentDetailsGridView
            // 
            this.departmentDetailsGridView.AllowUserToAddRows = false;
            this.departmentDetailsGridView.AllowUserToDeleteRows = false;
            this.departmentDetailsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.departmentDetailsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.departmentDetailsGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.departmentDetailsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.departmentDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentDetailsGridView.ColumnHeadersVisible = false;
            this.departmentDetailsGridView.Location = new System.Drawing.Point(0, 21);
            this.departmentDetailsGridView.Name = "departmentDetailsGridView";
            this.departmentDetailsGridView.ReadOnly = true;
            this.departmentDetailsGridView.RowHeadersVisible = false;
            this.departmentDetailsGridView.RowHeadersWidth = 51;
            this.departmentDetailsGridView.RowTemplate.Height = 24;
            this.departmentDetailsGridView.Size = new System.Drawing.Size(401, 163);
            this.departmentDetailsGridView.TabIndex = 5;
            // 
            // departmentDetailsGroupBox
            // 
            this.departmentDetailsGroupBox.Controls.Add(this.departmentDetailsGridView);
            this.departmentDetailsGroupBox.Controls.Add(this.editDepartmentButton);
            this.departmentDetailsGroupBox.Controls.Add(this.removeDepartmentButton);
            this.departmentDetailsGroupBox.Controls.Add(this.addDepartmentButton);
            this.departmentDetailsGroupBox.Location = new System.Drawing.Point(10, 445);
            this.departmentDetailsGroupBox.Name = "departmentDetailsGroupBox";
            this.departmentDetailsGroupBox.Size = new System.Drawing.Size(403, 249);
            this.departmentDetailsGroupBox.TabIndex = 12;
            this.departmentDetailsGroupBox.TabStop = false;
            this.departmentDetailsGroupBox.Text = "Информация об отделе";
            // 
            // employeesGroupBox
            // 
            this.employeesGroupBox.Controls.Add(this.addEmployeeButton);
            this.employeesGroupBox.Controls.Add(this.editEmployeeButton);
            this.employeesGroupBox.Controls.Add(this.employeesGridView);
            this.employeesGroupBox.Controls.Add(this.removeEmployeeButton);
            this.employeesGroupBox.Location = new System.Drawing.Point(437, 33);
            this.employeesGroupBox.Name = "employeesGroupBox";
            this.employeesGroupBox.Size = new System.Drawing.Size(933, 661);
            this.employeesGroupBox.TabIndex = 13;
            this.employeesGroupBox.TabStop = false;
            this.employeesGroupBox.Text = "Сотрудники отдела";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 699);
            this.Controls.Add(this.employeesGroupBox);
            this.Controls.Add(this.departmentDetailsGroupBox);
            this.Controls.Add(this.departmentsViewGroupBox);
            this.Controls.Add(this.companyNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyDBBrowser";
            this.departmentsViewGroupBox.ResumeLayout(false);
            this.departmentsViewGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDetailsGridView)).EndInit();
            this.departmentDetailsGroupBox.ResumeLayout(false);
            this.employeesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.TreeView departmentTreeView;
        private System.Windows.Forms.GroupBox departmentsViewGroupBox;
        private System.Windows.Forms.RadioButton listViewRadioButton;
        private System.Windows.Forms.RadioButton treeViewRadioButton;
        private System.Windows.Forms.DataGridView employeesGridView;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button editEmployeeButton;
        private System.Windows.Forms.Button removeEmployeeButton;
        private System.Windows.Forms.ListBox departmentListBox;
        private System.Windows.Forms.Button editDepartmentButton;
        private System.Windows.Forms.Button addDepartmentButton;
        private System.Windows.Forms.Button removeDepartmentButton;
        private System.Windows.Forms.DataGridView departmentDetailsGridView;
        private System.Windows.Forms.GroupBox departmentDetailsGroupBox;
        private System.Windows.Forms.GroupBox employeesGroupBox;
    }
}

