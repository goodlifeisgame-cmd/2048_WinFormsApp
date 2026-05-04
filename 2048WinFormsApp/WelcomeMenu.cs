namespace _2048WinFormsApp
{
    public partial class WelcomeMenu : Form
    {
        public string Name;

        public WelcomeMenu()
        {
            InitializeComponent();
        }

        private void WelcomeMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (userNametextBox.Text == string.Empty)
                {
                    return;
                }

                Name = userNametextBox.Text;
                Close();
            }
        }
    }
}
