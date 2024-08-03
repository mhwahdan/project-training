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
            submitBtn.Text = "NotSharkawyz";
            //MessageBox.Show("sharkawy");
        }

        private void submitBtn_MouseLeave(object sender, EventArgs e)
        {
            submitBtn.Text = "new ge";
        }

        private void submitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
