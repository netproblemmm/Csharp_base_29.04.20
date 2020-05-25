// Ястребов Юрий
// 2. Используя Windows Forms, разработать игру «Угадай число».
// Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток.
// Компьютер говорит, больше или меньше загаданное число введенного.
// a) Для ввода данных от человека используется элемент TextBox;
// б) ** Реализовать отдельную форму c TextBox для ввода числа.

using System;
using System.Windows.Forms;

namespace Lesson7_task2_GuessNumber
{
    public partial class Form1 : Form
    {
        int guessNumber;
        int tryCounter;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tbNumber.Visible = true;
            btnUserInput.Enabled = true;
            lblCompAnswer.Text = "";
            //guessNumber = rnd.Next(1, 101);
            guessNumber = 5;
            tryCounter = 2;
            lblTryCounter.Text = tryCounter.ToString();
        }

        private void btnUserInput_Click(object sender, EventArgs e)
        {
            int number = int.Parse(tbNumber.Text);
            tryCounter -= 1;
            lblTryCounter.Text = tryCounter.ToString();

            if (guessNumber == number)
            {
                lblCompAnswer.Text = "ВЫ ОТГАДАЛИ!";
                btnUserInput.Enabled = false;
            }
            else
            {
                if (guessNumber > number)
                {
                    lblCompAnswer.Text = "Загаданное число больше";
                }
                else
                {
                    lblCompAnswer.Text = "Загаданное число меньше";
                }
                
                if (tryCounter == 0)
                {
                    lblCompAnswer.Text = "Проигрыш! Закончились попытки";
                    btnUserInput.Enabled = false;
                }
            }
            lblCompAnswer.Visible = true;
        }
    }
}
