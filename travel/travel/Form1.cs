namespace travel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string haradan = comboBox1.Text;
            string haraya = comboBox2.Text;
            string tarix = maskedTextBox1.Text;
            string saat = maskedTextBox2.Text;
            string yer = textBox1.Text;
            string ad = textBox2.Text;
            string sv = maskedTextBox3.Text;
            string telefon = maskedTextBox4.Text;
            string email = textBox3.Text;
            listBox1.Items.Add($"{haradan} {haraya} {tarix} {saat} {yer} {ad} {sv} {telefon} {email}");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.Text);
            MessageBox.Show("Melumatlar bazadan silindi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           string variable1=comboBox1.Text;
           
           string variable2=comboBox2.Text;
            comboBox1.Text = variable2;
            comboBox2.Text = variable1; 
          
            

        }
    }
}
