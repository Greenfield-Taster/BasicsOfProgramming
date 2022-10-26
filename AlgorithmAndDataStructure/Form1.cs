using Microsoft.VisualBasic;

namespace AlgorithmAndDataStructure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string filepath = @"D:\College\AlgorithmAndDataStructure\AlgorithmAndDataStructure\Name.txt";

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(filepath);
            file.Create();
            MessageBox.Show("���� ������!");
        }

        private void �������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(filepath);
            file.Delete();
            MessageBox.Show("���� ������!");
        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(filepath);
            string newName = Interaction.InputBox("������� ����� ���");
            string newPath = @"D:\College\AlgorithmAndDataStructure\AlgorithmAndDataStructure\" + newName + ".txt";

            file.MoveTo(newPath);
            filepath = newPath;
            MessageBox.Show("���� ��������!");
        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter writeText = new StreamWriter(filepath, false))
            {
                writeText.WriteLine(textBoxWriteText.Text);
            }
            textBoxWriteText.Clear();
        }

        private void ���������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter writeText = new StreamWriter(filepath, true))
            {
                writeText.WriteLine(textBoxWriteText.Text);
            }
            textBoxWriteText.Clear();
        }

        private void ������������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamReader readText = new StreamReader(filepath))
            {
                var tempText = readText.ReadToEnd();
                int count = 0;

                for (int i = 0; i < tempText.Length; i++)
                {
                    if (tempText[i] == '�')
                    {
                        count++;
                    }
                }
                textBox1.Text = count.ToString();
            }
        }

        private void ����������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();

            using (StreamReader readText = new StreamReader(filepath))
            {
                listBoxOutput.Items.Add(readText.ReadToEnd());

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form1 form in Application.OpenForms)
            {
                form.Close();
            }
        }
    }
}