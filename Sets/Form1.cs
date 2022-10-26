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
            IEnumerable<int> unionResult = collection1.Union(collection2);
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
            string result = CollectionAContaintsCollectionB(collection1, collection2);
            labelResult.Text = result;
        }

        public string CollectionAContaintsCollectionB(List<int> collectionA, List<int> collectionB)
        {
            if (collectionB.Count > collectionA.Count)
            {
                return "Множество В больше множества А!";
            }

            for (int indexA = 0; indexA < collectionA.Count; indexA++)
            {
                int startB = collectionB[0];

                if (collectionA[indexA] == startB)
                {
                    int startIndexA = indexA;

                    for (int indexB = 0; indexB < collectionB.Count; indexB++)
                    {
                        if (startIndexA > collectionA.Count - 1)
                        {
                            break;
                        }

                        if (collectionA[startIndexA] == collectionB[indexB])
                        {
                            startIndexA++;
                            continue;
                        }

                        break;
                    }
                    return "Можество А содержит множество В";
                }
            }
            return "Можество А не содержит множество В";
        }

        private void вСодержитсяВАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = CollectionAContaintsCollectionB(collection2, collection1);
            labelResult.Text = result;
        }

        private void принадлежностьЭлтаМнвуАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string userInput = Interaction.InputBox("Введите число: ");
            int userNumber = int.Parse(userInput);

            for (int index = 0; index < collection1.Count; index++)
            {
                if (collection1[index] ==userNumber)
                {
                    labelResult.Text = "Значение принадлежит множеству А";
                    return;
                }
            }
            labelResult.Text = "Значение не принадлежит множеству А";
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
            if (collection1.Count != collection2.Count)
            {
                labelResult.Text = "Множествo А не равен множеству В";
                return;
            }

            for (int index = 0; index < collection1.Count; index++)
            {
                if (collection1[index] != collection2[index])
                {
                    labelResult.Text = "Множествo А не равен множеству В";
                    return;
                }
            }

            //на этом моменте коллекции равны
            string userInput = Interaction.InputBox("Введите число: ");
            int userNumber = int.Parse(userInput);

            textBoxB.Text += $" {userNumber}";
            labelResult.Text = string.Empty;
        }
    }
}
