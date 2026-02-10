namespace _4buyukleroyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="oyuncu" || textBox2.Text == "1234")//ikisinden biri saðlanýyorsa
            {
                Form2 oyun= new Form2();
                oyun.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalý Giriþ!");
            }
        }
    }
}