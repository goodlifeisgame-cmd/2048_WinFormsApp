namespace _2048WinFormsApp
{
    public partial class SettingMap : Form
    {
        public int SizeMap = 4;
        public SettingMap()
        {
            InitializeComponent();
        }

        private void onebutton_Click(object sender, EventArgs e)
        {
            SizeMap = 4;
            Close();
        }

        private void twobutton_Click(object sender, EventArgs e)
        {
            SizeMap = 3;
            Close();
        }

        private void threebutton_Click(object sender, EventArgs e)
        {
            SizeMap = 6;
            Close();
        }
    }
}
