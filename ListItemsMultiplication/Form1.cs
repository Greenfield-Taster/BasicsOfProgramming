using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ListItemsMultiplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            // GetNumbersFromString возвращает список чисел в переменную 
            List<int> numbers = GetNumbersFromString(textBoxNumbers.Text);

            int kol = 0;

            int sum = 0;

            for (int index = 0; index < numbers.Count; index++)
            {
                // Добуток на непарних місцях
                if ((index % 2) == 1) // Потому что массив начинается с "0"
                {
                    sum += numbers[index];
                    kol++;
                }
            }

            labelSum.Text = $"Сумма на парных местах: {sum}";

            labelKol.Text = $"Количество эл на парных местах:  {kol}";
        }

        private List<int> GetNumbersFromString(string source)
        {
            // Можно добавить размерность 
            List<int> listOfNumbers = new List<int>();

            for (int index = 0; index < source.Length; index++)
            {
                // Текущий символ
                char currentSymbol = source[index];

                // Проверка на число
                if (Char.IsDigit(currentSymbol))
                {
                    int number;

                    if (int.TryParse(currentSymbol.ToString(), out number))
                    {
                        listOfNumbers.Add(number);
                    }
                }
            }
            return listOfNumbers;
        }
    }
}