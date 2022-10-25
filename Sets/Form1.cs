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

namespace Sets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int ASize = 3;
        public static int BSize = 3;

        public string[] A = new string[ASize];
        public string[] B = new string[BSize];

        public static void Input(string[] A, string[] B = null)
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Interaction.InputBox($"Введите элемент {i + 1} множества А");
            }

            if (B != null)
                for (int i = 0; i < B.Length; i++)
                {
                    B[i] = Interaction.InputBox($"Введите элемент {i + 1} множества B");
                }
        }


        private void объединениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Input(A, B);
            listBox1.Items.Add(A.Union(B));
        }

        private void пересечениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Input(A, B);
            listBox1.Items.Add(A.Intersect(B));
        }

        private void вычитаниеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Input(A, B);
            listBox1.Items.Add(A.Except(B));
        }

        private void сравнениеАВToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Input(A, B);
            listBox1.Items.Add(A.SequenceEqual(B));
        }

        private void аСодержитсяВВToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int k = 0;
            for (int i = 0; i < A.Length; i++)
                if (B.Contains(A[i]))
                    k++;

            listBox1.Items.Add(B.Length == k);
        }

        private void вСодержитсяВАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int k = 0;
            for (int i = 0; i < B.Length; i++)
                if (A.Contains(B[i]))
                    k++;

            listBox1.Items.Add(A.Length == k);
        }

        private void принадлежностьЭлтаМнвуАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Input(A);

            if (A.Contains(Interaction.InputBox($"Введите элемент для проверки")))
            {
                listBox1.Items.Add("Элемент принадлежит множеству А");
            }
            else
            {
                listBox1.Items.Add("Элемент не принадлежит множеству А");
            }

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
