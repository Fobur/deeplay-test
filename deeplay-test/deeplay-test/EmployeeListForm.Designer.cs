namespace deeplay_test
{
    partial class EmployeeListForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employeeGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxFullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxJobTitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxInfoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteEmployeeButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.editEmployeeButton = new System.Windows.Forms.Button();
            this.jobTitleFilterComboBox = new System.Windows.Forms.ComboBox();
            this.jobTitleFilterLabel = new System.Windows.Forms.Label();
            this.departmentFilterLabel = new System.Windows.Forms.Label();
            this.departmentFilterComboBox = new System.Windows.Forms.ComboBox();
            this.filterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeGridView
            // 
            this.employeeGridView.AllowUserToAddRows = false;
            this.employeeGridView.AllowUserToDeleteRows = false;
            this.employeeGridView.AllowUserToResizeColumns = false;
            this.employeeGridView.AllowUserToResizeRows = false;
            this.employeeGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.employeeGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.employeeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxIDColumn,
            this.dataGridViewTextBoxFullNameColumn,
            this.dataGridViewTextBoxJobTitleColumn,
            this.dataGridViewTextBoxInfoColumn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.employeeGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.employeeGridView.GridColor = System.Drawing.Color.Black;
            this.employeeGridView.Location = new System.Drawing.Point(12, 79);
            this.employeeGridView.MultiSelect = false;
            this.employeeGridView.Name = "employeeGridView";
            this.employeeGridView.ReadOnly = true;
            this.employeeGridView.RowHeadersVisible = false;
            this.employeeGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.employeeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeGridView.ShowEditingIcon = false;
            this.employeeGridView.Size = new System.Drawing.Size(540, 424);
            this.employeeGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxIDColumn
            // 
            this.dataGridViewTextBoxIDColumn.HeaderText = "ID:";
            this.dataGridViewTextBoxIDColumn.Name = "dataGridViewTextBoxIDColumn";
            this.dataGridViewTextBoxIDColumn.ReadOnly = true;
            this.dataGridViewTextBoxIDColumn.Width = 40;
            // 
            // dataGridViewTextBoxFullNameColumn
            // 
            this.dataGridViewTextBoxFullNameColumn.HeaderText = "ФИО:";
            this.dataGridViewTextBoxFullNameColumn.Name = "dataGridViewTextBoxFullNameColumn";
            this.dataGridViewTextBoxFullNameColumn.ReadOnly = true;
            this.dataGridViewTextBoxFullNameColumn.Width = 140;
            // 
            // dataGridViewTextBoxJobTitleColumn
            // 
            this.dataGridViewTextBoxJobTitleColumn.HeaderText = "Должность:";
            this.dataGridViewTextBoxJobTitleColumn.Name = "dataGridViewTextBoxJobTitleColumn";
            this.dataGridViewTextBoxJobTitleColumn.ReadOnly = true;
            this.dataGridViewTextBoxJobTitleColumn.Width = 180;
            // 
            // dataGridViewTextBoxInfoColumn
            // 
            this.dataGridViewTextBoxInfoColumn.HeaderText = "Спец информация:";
            this.dataGridViewTextBoxInfoColumn.Name = "dataGridViewTextBoxInfoColumn";
            this.dataGridViewTextBoxInfoColumn.ReadOnly = true;
            this.dataGridViewTextBoxInfoColumn.Width = 177;
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.Location = new System.Drawing.Point(560, 79);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(97, 50);
            this.deleteEmployeeButton.TabIndex = 1;
            this.deleteEmployeeButton.Text = "Удалить сотрудника";
            this.deleteEmployeeButton.UseVisualStyleBackColor = true;
            this.deleteEmployeeButton.Click += new System.EventHandler(this.deleteEmployeeButton_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(560, 145);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(97, 50);
            this.addEmployeeButton.TabIndex = 2;
            this.addEmployeeButton.Text = "Добавить сотрудника";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editEmployeeButton
            // 
            this.editEmployeeButton.Location = new System.Drawing.Point(559, 453);
            this.editEmployeeButton.Name = "editEmployeeButton";
            this.editEmployeeButton.Size = new System.Drawing.Size(98, 50);
            this.editEmployeeButton.TabIndex = 3;
            this.editEmployeeButton.Text = "Редактировать";
            this.editEmployeeButton.UseVisualStyleBackColor = true;
            this.editEmployeeButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // jobTitleFilterComboBox
            // 
            this.jobTitleFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobTitleFilterComboBox.FormattingEnabled = true;
            this.jobTitleFilterComboBox.Items.AddRange(new object[] {
            "Любая",
            "Директор",
            "Руководитель подразделения",
            "Контролер",
            "Рабочий"});
            this.jobTitleFilterComboBox.Location = new System.Drawing.Point(12, 50);
            this.jobTitleFilterComboBox.Name = "jobTitleFilterComboBox";
            this.jobTitleFilterComboBox.SelectedIndex = 0;
            this.jobTitleFilterComboBox.Size = new System.Drawing.Size(205, 23);
            this.jobTitleFilterComboBox.TabIndex = 4;
            // 
            // jobTitleFilterLabel
            // 
            this.jobTitleFilterLabel.Location = new System.Drawing.Point(12, 21);
            this.jobTitleFilterLabel.Name = "jobTitleFilterLabel";
            this.jobTitleFilterLabel.Size = new System.Drawing.Size(205, 23);
            this.jobTitleFilterLabel.TabIndex = 6;
            this.jobTitleFilterLabel.Text = "Отбор по должности:";
            this.jobTitleFilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // departmentFilterLabel
            // 
            this.departmentFilterLabel.Location = new System.Drawing.Point(248, 21);
            this.departmentFilterLabel.Name = "departmentFilterLabel";
            this.departmentFilterLabel.Size = new System.Drawing.Size(203, 23);
            this.departmentFilterLabel.TabIndex = 7;
            this.departmentFilterLabel.Text = "Отбор по подразделению:";
            this.departmentFilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // departmentFilterComboBox
            // 
            this.departmentFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentFilterComboBox.FormattingEnabled = true;
            this.departmentFilterComboBox.Items.AddRange(new object[] {
            "Любое",
            "Подразделение 1",
            "Подразделение 2",
            "Подразделение 3"});
            this.departmentFilterComboBox.Location = new System.Drawing.Point(248, 50);
            this.departmentFilterComboBox.SelectedIndex = 0;
            this.departmentFilterComboBox.Name = "departmentFilterComboBox";
            this.departmentFilterComboBox.Size = new System.Drawing.Size(203, 23);
            this.departmentFilterComboBox.TabIndex = 8;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(478, 36);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 9;
            this.filterButton.Text = "Отбор";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 524);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.departmentFilterLabel);
            this.Controls.Add(this.departmentFilterComboBox);
            this.Controls.Add(this.jobTitleFilterLabel);
            this.Controls.Add(this.jobTitleFilterComboBox);
            this.Controls.Add(this.editEmployeeButton);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.deleteEmployeeButton);
            this.Controls.Add(this.employeeGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EmployeeListForm";
            this.Text = "Управление персоналом";
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView employeeGridView;
        private Button deleteEmployeeButton;
        private Button addEmployeeButton;
        private Button editEmployeeButton;
        private ComboBox jobTitleFilterComboBox;
        private Label jobTitleFilterLabel;
        private Label departmentFilterLabel;
        private ComboBox departmentFilterComboBox;
        private Button filterButton;
        private DataGridViewTextBoxColumn dataGridViewTextBoxIDColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxFullNameColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxJobTitleColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxInfoColumn;
    }
}