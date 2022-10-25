using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WorkWithRecords
{
    public partial class Form1 : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            Student[] student = new Student[2];
            Student.Input(student);
            Student.Output(student, listBox1);
        }
    }
    public class Student
    {
        public string Names;
        public int[] Marks;

        public static void Input(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
                students[i].Marks = new int[4];
                students[i].Names = Interaction.InputBox($"Введите имя студента {i + 1}");

                for (int j = 0; j < students[i].Marks.Length; j++)
                {
                    students[i].Marks[j] = int.Parse(Interaction.InputBox($"Введите {j + 1} оценку студента {i + 1}"));
                }
            }
        }

        public static void Output(Student[] students, ListBox list)
        {
            string ExcellentStudent;
            list.Items.Add("№/tПрізвище-Імя/tОцiнки/tУспiшнiсть");


            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Marks.Sum() == 20)
                    ExcellentStudent = "Отличник";
                else
                    ExcellentStudent = "Не отличник";

                list.Items.Add($"{i + 1}/t{students[i].Names}/t{students[i].Marks[0]}/t{students[i].Marks[1]}/t{students[i].Marks[2]}/t{students[i].Marks[3]}/t{ExcellentStudent}");
            }
        }
    }
}
