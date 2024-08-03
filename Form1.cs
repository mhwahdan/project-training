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
            MessageBox.Show("sharkawy");
        }

        private void submitBtn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
