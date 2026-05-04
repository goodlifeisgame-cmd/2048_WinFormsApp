namespace _2048WinFormsApp
{
    public partial class TableResults : Form
    {
        public TableResults()
        {
            InitializeComponent();

            resultsDataGridView.Columns.Add("Name", "Name");
            resultsDataGridView.Columns.Add("Score", "Score");

            var users = ResultStorage.GetAll();
            foreach (var user in users)
            {
                resultsDataGridView.Rows.Add(user.Name, user.Score);
            }


        }
    }
}
