using MongoDB.Bson;

namespace deeplay_test
{
    public partial class EmployeeEditor : Form
    {
        bool isEdit = false;

        public EmployeeEditor(bool isEdit)
        {
            InitializeComponent();
        }

        public EmployeeEditor(Employee editableEmployee)
        {
            InitializeComponent();

            isEdit = true;
            idTextBox.Text = editableEmployee.Id.ToString();
            surnameTextBox.Text = editableEmployee.Personality.Name;
            nameTextBox.Text = editableEmployee.Personality.Surname;
            patronymicTextBox.Text = editableEmployee.Personality.Patronymic;
            dateOfBirthPicker.Value = editableEmployee.Personality.DateOfBirth;

            var sexIndex = Collections.SexReverseDict[editableEmployee.Personality.Sex];
            sexChoiceComboBox.SelectedIndex = sexIndex;
            var jobTitleIndex = Collections.JobTitlesReverseDict[editableEmployee.JobTitle.Title];
            jobTitleChoiceComboBox.SelectedIndex = jobTitleIndex;
        }

        private async void generateIDButton_Click(object sender, EventArgs e)
        {
            var task = await DataBase.Filter(new BsonDocument());
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
                var employee = new Employee(fullName, dateOfBirthPicker.Value,
                sexChoiceComboBox.SelectedItem.ToString(),
                jobTitleChoiceComboBox.SelectedItem.ToString(),
                uniqueInformationChoiceComboBox.SelectedItem.ToString(),
                int.Parse(idTextBox.Text));
                var cursor = await DataBase.Filter(new BsonDocument { { "_id", idTextBox.Text } });
                if (await cursor.MoveNextAsync())
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
                    uniqueInfo = await DataBase.GetArrayOfSupervisorsByJobTitle(Collections.JobTitlesDict[index]);
                    break;
                case 3:
                    uniqueInfo = await DataBase.GetArrayOfSupervisorsByJobTitle(Collections.JobTitlesDict[index]);
                    break;
            }
            uniqueInformationChoiceComboBox.Items.AddRange(uniqueInfo);
            uniqueInformationChoiceComboBox.SelectedIndex = 0;
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
