using System;
using System.Windows.Forms;

namespace PR8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == '.' || textBox1.Text[i] == '!' || textBox1.Text[i] == '!')
                    count++;
            }
            textBox2.Text = count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int iterator = 0;
            for (int i = 0; i < textBox1.Text.Length && iterator < textBox4.Text.Length; i++)
            {
                if (textBox1.Text[i] == textBox4.Text[iterator])
                {
                    iterator++;
                }
            }

            if (iterator == textBox4.Text.Length)
                textBox4.Text = textBox1.Text.Replace(textBox3.Text, "");
            else
                textBox3.Text = "Не мiстить";

        }
    }
}
