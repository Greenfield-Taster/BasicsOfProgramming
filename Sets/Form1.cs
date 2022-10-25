using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sets
{
    public partial class Form1 : Form
    {
        private List<int> collection1 = new List<int>();
        private List<int> collection2 = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            collection1.Clear();
            collection2.Clear();

            string textA = textBoxA.Text;
            string textB = textBoxB.Text;

            string[] splitedTextA = textA.Split(' ');
            string[] splitedTextB = textB.Split(' ');

            int[] a = splitedTextA
                .Where(x => !string.IsNullOrWhiteSpace(x)) // Запускает foreach и проверяет чтоб элемент не был пустым
                .Select(x => int.Parse(x)) // Запускает foreach и переводит элемент в int
                .ToArray(); // Переводим в массив 

            int[] b = splitedTextB
                .Where(x => !string.IsNullOrWhiteSpace(x)) // Запускает foreach и проверяет чтоб элемент не был пустым
                .Select(x => int.Parse(x)) // Запускает foreach и переводит элемент в int
                .ToArray(); // Переводим в массив 

            collection1.AddRange(a);
            collection2.AddRange(b);
        }
        
        private string ConvertArrayToString(int[] array)
        {
            string numbers = string.Empty;

            for (int i = 0; i < array.Length; i++)
            {
                numbers += $"{array[i]}, ";
            }
            return numbers;
        }

        private void объединениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<int> unionResult  = collection1.Union(collection2);
            string output = ConvertArrayToString(unionResult.ToArray());
            labelResult.Text = output;
        }

        private void пересечениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IEnumerable<int> intersectResult = collection1.Intersect(collection2);
            string output = ConvertArrayToString(intersectResult.ToArray());
            labelResult.Text = output;
        }

        private void вычитаниеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IEnumerable<int> exceptResult = collection1.Except(collection2);
            string output = ConvertArrayToString(exceptResult.ToArray());
            labelResult.Text = output;
        }

        private void сравнениеАВToolStripMenuItem_Click(object sender, EventArgs e)
        {
             bool equalsResult = Enumerable.Equals(collection1, collection2);
            labelResult.Text = equalsResult.ToString();
        }

        private void аСодержитсяВВToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count;
            for (int i = 0; i < ; i++)
            {

            }
        }

        private void вСодержитсяВАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void принадлежностьЭлтаМнвуАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutProgram form = new FormAboutProgram();
            form.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }

        }

        private void иДЗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIDZ form = new FormIDZ();
            form.Show();
        }
    }
}
