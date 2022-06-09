using MongoDB.Bson;

namespace deeplay_test
{
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm()
        {
            InitializeComponent();
            UpdateTable();
        }

        private async void editButton_Click(object sender, EventArgs e)
        {
            var selectedRows = employeeGridView.SelectedRows;
            if (selectedRows.Count != 0)
            {
                var filter = new BsonDocument{{"_id",
                (int)employeeGridView.SelectedRows[0].Cells[0].Value }};
                var cursor = await DataBase.Filter(filter);
                await cursor.MoveNextAsync();
                var employee = cursor.Current.First();
                var employeeEdit = new EmployeeEditor(employee);
                employeeEdit.ShowDialog();
                await UpdateTable();
            }
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            var employeeEdit = new EmployeeEditor(false);
            employeeEdit.ShowDialog();
            await UpdateTable();
        }

        private async void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            var selectedRows = employeeGridView.SelectedRows;
            if (selectedRows.Count != 0)
            {
                var filter = new BsonDocument(new BsonElement("_id",
                (int)selectedRows[0].Cells[0].Value));
                var cursor = await DataBase.Filter(filter);
                if (!await cursor.MoveNextAsync())
                    return;
                var employee = cursor.Current.First();
                await DataBase.Delete(employee);
                employeeGridView.Rows.RemoveAt(selectedRows[0].Index);
            }
        }

        private async void filterButton_Click(object sender, EventArgs e)
        {
            await UpdateTable();
        }

        public async Task UpdateTable()
        {
            var jobTitleFilter = new BsonDocument();
            if (jobTitleFilterComboBox.SelectedIndex != 0)
                jobTitleFilter.Add("JobTitle.Title", jobTitleFilterComboBox.SelectedItem.ToString());
            if (departmentFilterComboBox.SelectedIndex != 0)
                jobTitleFilter.Add("JobTitle.Information", departmentFilterComboBox.SelectedItem.ToString());
            await FillTable(jobTitleFilter);
        }

        public async Task FillTable(BsonDocument filter)
        {
            var filtered = await DataBase.Filter(filter);
            employeeGridView.Rows.Clear();
            await filtered.MoveNextAsync();
            var current = filtered.Current;
            
            foreach (var employee in current)
            {
                employeeGridView.Rows.Add(employee.Id, employee.Personality.GetFullName(),
                    employee.JobTitle.Title, employee.JobTitle.Information);
            }
        }
    }
}