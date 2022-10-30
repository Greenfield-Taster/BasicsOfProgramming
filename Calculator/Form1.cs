    using Microsoft.VisualBasic;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LinkedList<int> list = new LinkedList<int>();

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            list.AddFirst(int.Parse(textBoxFirstElem.Text));
            foreach (var element in list)
            {
                listBox1.Items.Add(element);
            }
        }

        private void buttonСonstruction_Click(object sender, EventArgs e)
        {
            while (true)
            {
                int tempElement = int.Parse(Interaction.InputBox("Введите элемент, конец ввода - 0"));
                if (tempElement == 0) 
                {
                    break;
                }

                list.AddLast(tempElement);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            list.Clear();
            listBox1.Items.Clear();
            textBoxFirstElem.Text = "";
            textBoxSearchElem.Text = "";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int tempNumber = int.Parse(textBoxSearchElem.Text);

            if (tempNumber != 0)
            {
                int index = -1;

                for (int i = 0; i < list.Count; i++)
                {
                    if (list.ElementAt(i) == tempNumber)
                    {
                        index = i;
                        labelResult.Text = "Элемент присутствует в коллекции!";
                    }
                }

                if (index == -1)
                {
                    labelResult.Text = "Такого элемента нет в коллекции!";
                    MessageBox.Show("Такого элемента нет в коллекции!");
                }
                else
                {
                    MessageBox.Show("Элемент присутствует в коллекции!");
                }
            }
        }
    }
}