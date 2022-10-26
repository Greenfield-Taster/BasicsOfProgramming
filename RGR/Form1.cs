using Microsoft.VisualBasic;
using System.Data.Common;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RGR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridViewInput.ColumnCount = 4;
            dataGridViewInput.RowCount = 4;
            dataGridViewOutput.ColumnCount = 4;
            dataGridViewOutput.RowCount = 4;
        }

        public static int[,] matrix = new int[4, 4];

        public static string filepath = @"D:\College\AlgorithmAndDataStructure\AlgorithmAndDataStructure\NameRGR.txt";

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(filepath);
            file.Create();
            MessageBox.Show("Файл создан!");
        }

        private void удалитьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(filepath);
            file.Delete();
            MessageBox.Show("Файл удален!");
        }

        private void сохранитьИзмененияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(filepath);
            string newName = Interaction.InputBox("Введите новое имя");
            string newPath = @"D:\College\AlgorithmAndDataStructure\AlgorithmAndDataStructure\RGR" + newName + ".txt";

            file.MoveTo(newPath);
            filepath = newPath;
            MessageBox.Show("Файл сохранен!");
        }

        private void записатьМатрицу44ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(StreamWriter feliWriter = new StreamWriter(filepath, false))
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        feliWriter.Write(matrix[i, j].ToString() + " ");
                    }
                    feliWriter.WriteLine();
                }
            }
        }

        public static void Output(int[,] Matrix, ListBox list)
        {
            list.Items.Clear();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    list.Items.Add($"Matrix[{i},{j}] - {matrix[i, j]}");
                }
            }
        }

        private void вывестиМатрицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();

            try
            {
                using(StreamReader fileRead = new StreamReader(filepath))
                {
                    string[] temp = new string[4];
                    
                    for (int i = 0; i < 4; i++)
                    {
                        temp[i] = fileRead.ReadLine();
                    }

                    for (int i = 0; i < 4; i++)
                    {
                        listBoxOutput.Items.Add(temp[i]);
                    }
                }
                Output(matrix,listBoxOutput);
            }
            catch
            {
                MessageBox.Show("Файл з таким именем уже существует");
            }
        }

        private void ввестиМатрицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i,j] = rnd.Next(15);
                    dataGridViewInput.Rows[i].Cells[j].Value = matrix[i,j];
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form1 form in Application.OpenForms)
            {
                form.Close();
            }
        }

        private void умножНаJСтолбецToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int[] tempColumn = new int[matrix.GetLength(0)];
            int number = int.Parse(Interaction.InputBox("Введите номер столбца 1-4: "));
            int n = int.Parse(Interaction.InputBox($"Введите число на которое умножить {number} столбец: "));

            for (int j = 0; j < matrix.GetLength(0) && j < tempColumn.Length; j++)
            {
                matrix[j, number] *= n;
            }
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridViewOutput.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }           
        }
    }
}