namespace project_training
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TestContext testContext = new TestContext();

            Patient patient = (from _patient in testContext.Patients 
                               where _patient.Age >= 0
                               select _patient).FirstOrDefault();
            submitBtn.Text = patient.Name;
        }

        private void submitBtn_MouseHover(object sender, EventArgs e)
        {
            submitBtn.Text = "NotSharkawyz";
            //MessageBox.Show("sharkawy conflict");
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

        private void submitBtn_MouseClick(object sender, MouseEventArgs e)
        {

            TestContext testContext = new TestContext();

            testContext.Patients.Add(new Patient
            {
                Id = 1,
                Name = "wahdan"
            });
            testContext.SaveChanges();

        }

        private void submitBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
