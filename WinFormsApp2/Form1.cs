using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void High_SelectedIndexChanged(object sender, EventArgs e)
        {

            MessageBox.Show("Aceasta este o sarcina cu prioritate inalta", "Prioritate inalta");
        }

        public void Medium_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta este o sarcina cu prioritate medie", "Prioritate medie");
        }

        public void Low_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Aceasta este o sarcina cu prioritatea neprioritara\n");
            string text = textBox1.Text;
            listBox2.Items.Add($" {text}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Aceasta este o sarcina cu prioritatea medie\n");
            string text = textBox1.Text;
            listBox3.Items.Add($" {text}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Aceasta este o sarcina cu prioritatea inalta\n");
            string text = textBox1.Text;
            listBox4.Items.Add($" {text}");
        }
    }
}