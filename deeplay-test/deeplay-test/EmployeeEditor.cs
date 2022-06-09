using MongoDB.Bson;

namespace deeplay_test
{
    public partial class EmployeeEditor : Form
    {
        bool isEdit;
        Employee employee;

        public EmployeeEditor(bool isEdit)
        {
            InitializeComponent();
        }

        public EmployeeEditor(Employee editableEmployee)
        {
            InitializeComponent();
            employee = editableEmployee;
            isEdit = true;
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (isEdit)
            {
                idTextBox.Text = employee.Id.ToString();
                nameTextBox.Text = employee.Personality.Name;
                surnameTextBox.Text = employee.Personality.Surname;
                patronymicTextBox.Text = employee.Personality.Patronymic;
                dateOfBirthPicker.Value = employee.Personality.DateOfBirth;

                var sexIndex = Collections.SexReverseDict[employee.Personality.Sex];
                sexChoiceComboBox.SelectedIndex = sexIndex;
                var jobTitleIndex = Collections.JobTitlesReverseDict[employee.JobTitle.Title];
                jobTitleChoiceComboBox.SelectedIndex = jobTitleIndex;

                switch ((Collections.JobTitleEnum)jobTitleIndex)
                {
                    case (Collections.JobTitleEnum.Director):
                        uniqueInformationChoiceComboBox.SelectedIndex =
                            Collections.DirectorUniqueInfoReverseDict[employee.JobTitle.Information];
                        break;
                    case (Collections.JobTitleEnum.DepartmentHead):
                        uniqueInformationChoiceComboBox.SelectedIndex =
                            Collections.DepartmentHeadUniqueInfoReverseDict[employee.JobTitle.Information];
                        break;
                    default:
                        await set_uniqueInformationComboBox(jobTitleIndex);
                        var supervisors = uniqueInformationChoiceComboBox.Items;
                        uniqueInformationChoiceComboBox.SelectedIndex = supervisors.IndexOf(employee.JobTitle.Information.Replace("Руководитель: ", ""));
                        break;
                }
            }
        }

        private void AdjustWidthComboBox_DropDown(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            int width = senderComboBox.DropDownWidth;
            Graphics g = senderComboBox.CreateGraphics();
            Font font = senderComboBox.Font;
            int vertScrollBarWidth =
                (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems)
                ? SystemInformation.VerticalScrollBarWidth : 0;

            int newWidth;
            foreach (string s in senderComboBox.Items)
            {
                newWidth = (int)g.MeasureString(s, font).Width
                    + vertScrollBarWidth;
                if (width < newWidth)
                {
                    width = newWidth;
                }
            }
            senderComboBox.DropDownWidth = width;
        }

        private async void generateIDButton_Click(object sender, EventArgs e)
        {
            var task = await DataBase.Filter(new BsonDocument());
            await task.MoveNextAsync();
            var employeeCurrent = task.Current;
            if (employeeCurrent != null)
            {
                idTextBox.Text = (employeeCurrent.MaxBy(employee => employee.Id).Id + 1).ToString();
            }
            else
                idTextBox.Text = "0";
        }

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private async void endEditButton_Click(object sender, EventArgs e)
        {
            var fullName = $"{surnameTextBox.Text} {nameTextBox.Text} {patronymicTextBox.Text}";
            try
            {
                var uniqueInfo = uniqueInformationChoiceComboBox.SelectedItem.ToString();
                if (jobTitleChoiceComboBox.SelectedItem.ToString() == "Контролер" ||
                    jobTitleChoiceComboBox.SelectedItem.ToString() == "Рабочий" &&
                    jobTitleChoiceComboBox.SelectedIndex != 0)
                {
                    uniqueInfo = $"Руководитель: {uniqueInfo}";
                }
                var employee = new Employee(fullName, dateOfBirthPicker.Value,
                sexChoiceComboBox.SelectedItem.ToString(),
                jobTitleChoiceComboBox.SelectedItem.ToString(),
                uniqueInfo,
                int.Parse(idTextBox.Text));
                var cursor = await DataBase.Filter(new BsonDocument { { "_id", int.Parse(idTextBox.Text) } });
                await cursor.MoveNextAsync();
                if (cursor.Current.Count() != 0)
                    if (isEdit)
                        await DataBase.Update(employee);
                    else
                    {
                        MessageBox.Show("Сотрудник с таким ID уже существует", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                else
                    await DataBase.Add(employee);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void jobTitleChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = jobTitleChoiceComboBox.SelectedIndex;
            await set_uniqueInformationComboBox(index);
        }

        private async Task set_uniqueInformationComboBox(int index)
        {
            uniqueInformationChoiceComboBox.Items.Clear();
            string[] uniqueInfo = new string[0];
            switch (index)
            {
                case 0:
                    uniqueInfo = Collections.DirectorUniqueInfo;
                    break;
                case 1:
                    uniqueInfo = Collections.Departments;
                    break;
                case 2:
                    uniqueInfo = (await DataBase.GetArrayOfSupervisorsByJobTitle("Руководитель подразделения")).ToArray();
                    break;
                case 3:
                    uniqueInfo = (await DataBase.GetArrayOfSupervisorsByJobTitle("Контролер")).ToArray();
                    break;
            }
            uniqueInformationChoiceComboBox.Items.Clear();
            uniqueInformationChoiceComboBox.Items.AddRange(uniqueInfo);
            uniqueInformationChoiceComboBox.Enabled = true;
        }

        private void isAllFieldsCompleted(object sender, EventArgs e)
        {
            var isIdChosen = idTextBox.Text != "";
            var isNameChosen = nameTextBox.Text != "" &&
                surnameTextBox.Text != "" && patronymicTextBox.Text != "";
            var isSexChosen = sexChoiceComboBox.SelectedItem != null;
            var isJobTitleChosen = jobTitleChoiceComboBox.SelectedItem != null
                && uniqueInformationChoiceComboBox.SelectedItem != null;
            endEditButton.Enabled = isIdChosen && isNameChosen && isSexChosen && isJobTitleChosen;
        }
    }
}
