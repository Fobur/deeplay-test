namespace deeplay_test
{
    partial class EmployeeEditor : Form
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sexChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.jobTitleChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uniqueInformationLabel = new System.Windows.Forms.Label();
            this.uniqueInformationChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.endEditButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.generateIDButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Профиль сотрудника";
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.CausesValidation = false;
            this.dateOfBirthPicker.Location = new System.Drawing.Point(145, 149);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(142, 23);
            this.dateOfBirthPicker.TabIndex = 1;
            this.dateOfBirthPicker.Value = new System.DateTime(2022, 6, 8, 19, 25, 3, 49);
            // 
            // sexChoiceComboBox
            // 
            this.sexChoiceComboBox.CausesValidation = false;
            this.sexChoiceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexChoiceComboBox.FormattingEnabled = true;
            this.sexChoiceComboBox.Items.AddRange(new object[] {
            "Женский",
            "Мужской"});
            this.sexChoiceComboBox.Location = new System.Drawing.Point(145, 187);
            this.sexChoiceComboBox.Name = "sexChoiceComboBox";
            this.sexChoiceComboBox.Size = new System.Drawing.Size(121, 23);
            this.sexChoiceComboBox.SelectedIndexChanged += isAllFieldsCompleted;
            this.sexChoiceComboBox.TabIndex = 2;
            // 
            // jobTitleChoiceComboBox
            // 
            this.jobTitleChoiceComboBox.CausesValidation = false;
            this.jobTitleChoiceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobTitleChoiceComboBox.FormattingEnabled = true;
            this.jobTitleChoiceComboBox.Items.AddRange(new object[] {
            "Директор",
            "Руководитель подразделения",
            "Контролер",
            "Рабочий"});
            this.jobTitleChoiceComboBox.Location = new System.Drawing.Point(145, 227);
            this.jobTitleChoiceComboBox.Name = "jobTitleChoiceComboBox";
            this.jobTitleChoiceComboBox.Size = new System.Drawing.Size(121, 23);
            this.jobTitleChoiceComboBox.TabIndex = 3;
            this.jobTitleChoiceComboBox.SelectedIndexChanged += new System.EventHandler(this.jobTitleChoiceComboBox_SelectedIndexChanged);
            this.jobTitleChoiceComboBox.SelectedIndexChanged += isAllFieldsCompleted;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(145, 74);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.PlaceholderText = "Только цифры";
            this.idTextBox.Size = new System.Drawing.Size(100, 23);
            this.idTextBox.TextChanged += isAllFieldsCompleted;
            this.idTextBox.TabIndex = 5;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(145, 110);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.PlaceholderText = "Фамилия";
            this.surnameTextBox.TextChanged += isAllFieldsCompleted;
            this.surnameTextBox.Size = new System.Drawing.Size(142, 23);
            this.surnameTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(104, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(87, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "ФИО:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Дата рождения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(87, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Пол:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(42, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Должность:";
            // 
            // uniqueInformationLabel
            // 
            this.uniqueInformationLabel.AutoSize = true;
            this.uniqueInformationLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uniqueInformationLabel.Location = new System.Drawing.Point(286, 228);
            this.uniqueInformationLabel.Name = "uniqueInformationLabel";
            this.uniqueInformationLabel.Size = new System.Drawing.Size(96, 19);
            this.uniqueInformationLabel.TabIndex = 15;
            this.uniqueInformationLabel.Text = "Информация:";
            // 
            // uniqueInformationChoiceComboBox
            // 
            this.uniqueInformationChoiceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uniqueInformationChoiceComboBox.Enabled = false;
            this.uniqueInformationChoiceComboBox.FormattingEnabled = true;
            this.uniqueInformationChoiceComboBox.Location = new System.Drawing.Point(388, 227);
            this.uniqueInformationChoiceComboBox.Name = "uniqueInformationChoiceComboBox";
            this.uniqueInformationChoiceComboBox.Size = new System.Drawing.Size(151, 23);
            this.uniqueInformationChoiceComboBox.TabIndex = 14;
            // 
            // endEditButton
            // 
            this.endEditButton.Enabled = false;
            this.endEditButton.Location = new System.Drawing.Point(42, 288);
            this.endEditButton.Name = "endEditButton";
            this.endEditButton.Size = new System.Drawing.Size(88, 23);
            this.endEditButton.TabIndex = 16;
            this.endEditButton.Text = "Подтвердить";
            this.endEditButton.UseVisualStyleBackColor = true;
            this.endEditButton.Click += new System.EventHandler(this.endEditButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(286, 110);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PlaceholderText = "Имя";
            this.nameTextBox.TextChanged += isAllFieldsCompleted;
            this.nameTextBox.Size = new System.Drawing.Size(142, 23);
            this.nameTextBox.TabIndex = 17;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(427, 110);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.PlaceholderText = "Отчество";
            this.patronymicTextBox.TextChanged += isAllFieldsCompleted;
            this.patronymicTextBox.Size = new System.Drawing.Size(142, 23);
            this.patronymicTextBox.TabIndex = 18;
            // 
            // generateIDButton
            // 
            this.generateIDButton.CausesValidation = false;
            this.generateIDButton.Location = new System.Drawing.Point(251, 73);
            this.generateIDButton.Name = "generateIDButton";
            this.generateIDButton.Size = new System.Drawing.Size(101, 23);
            this.generateIDButton.TabIndex = 19;
            this.generateIDButton.Text = "Сгенерировать";
            this.generateIDButton.UseVisualStyleBackColor = true;
            this.generateIDButton.Click += new System.EventHandler(this.generateIDButton_Click);
            // 
            // EmployeeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(581, 370);
            this.Controls.Add(this.generateIDButton);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.endEditButton);
            this.Controls.Add(this.uniqueInformationLabel);
            this.Controls.Add(this.uniqueInformationChoiceComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.jobTitleChoiceComboBox);
            this.Controls.Add(this.sexChoiceComboBox);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EmployeeEditor";
            this.Text = "Редактор профиля сотрудника";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private DateTimePicker dateOfBirthPicker;
        private BindingSource bindingSource1;
        private ComboBox sexChoiceComboBox;
        private ComboBox jobTitleChoiceComboBox;
        private TextBox idTextBox;
        private TextBox surnameTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label uniqueInformationLabel;
        private ComboBox uniqueInformationChoiceComboBox;
        private Button endEditButton;
        private TextBox nameTextBox;
        private TextBox patronymicTextBox;
        private Button generateIDButton;
    }
}