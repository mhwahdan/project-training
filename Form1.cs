namespace project_training
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitBtn_MouseHover(object sender, EventArgs e)
        {
            submitBtn.Text = "I am hovered on";
        }

        private void submitBtn_MouseLeave(object sender, EventArgs e)
        {
            submitBtn.Text = "new ge";
        }
    }
}
