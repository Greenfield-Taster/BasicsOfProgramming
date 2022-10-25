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
    public partial class FormIDZ : Form
    {
        public FormIDZ()
        {
            InitializeComponent();
        }

        string[] A = new string[3];
        string[] B = new string[3];

        public static string Element;

        public static void Input(string[] A, string[] B)
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Interaction.InputBox($"Введите элемент {i + 1} множества А");
            }

            for (int i = 0; i < B.Length; i++)
            {
                B[i] = Interaction.InputBox($"Введите элемент {i + 1} множества B");
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            listBoxA.Items.Clear();
            listBoxB.Items.Clear();
            listBoxResult.Items.Clear();

            Input(A, B);

            listBoxA.Items.AddRange(A.ToArray());
            listBoxB.Items.AddRange(B.ToArray());

            if (A.SequenceEqual(B))
            {
                int index = int.Parse(Interaction.InputBox($"Введите номер элемента для добавления"));
                Element = B[index];
                string[] Btemp = new string[B.Length + 1];
                for (int i = 1; i < Btemp.Length+1; i++)
                {
                    if (index == i)
                        continue;
                }
                //B = Btemp;
                listBoxResult.Items.Clear();
                listBoxResult.Items.AddRange(Btemp.ToArray());
            }
        }
    }
}