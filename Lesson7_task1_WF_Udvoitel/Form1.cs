// Ястребов Юрий
// 1. а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
// б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
// Игрок должен получить это число за минимальное количество ходов.
// в) * Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте обобщенный класс Stack.
// Вся логика игры должна быть реализована в классе с удвоителем.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lesson7_task1_WF_Udvoitel
{
    public partial class Form1: Form
    {
        int target;
        int score = 0;
        int cmdQty = 0;
        Random rnd = new Random();
        Stack stack = new Stack();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            target = rnd.Next(10, 100);
            MessageBox.Show($"Цель - набрать {target}");
            stack.Clear();
            btnStart.Enabled = false;
            btnCommand1.Enabled = true;
            btnCommand2.Enabled = false;
            lblTarget.Text = target.ToString();
            score = 0;
            cmdQty = 0;
            lblNumber.Text = score.ToString();
            lblQuantity.Text = cmdQty.ToString();
            lblResults.Visible = false;
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            score = int.Parse(lblNumber.Text) + 1;
            cmdQty = int.Parse(lblQuantity.Text) + 1;
            lblNumber.Text = score.ToString();
            lblQuantity.Text = cmdQty.ToString();
            CheckResults();
            stack.Add(score);
            if (score > 0 && score < target)
            {
                btnCommand2.Enabled = true;
                btnCancel.Enabled = true;
                btnReset.Enabled = true;
            }
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            score = int.Parse(lblNumber.Text) * 2;
            cmdQty = int.Parse(lblQuantity.Text) + 1;
            lblNumber.Text = score.ToString();
            lblQuantity.Text = cmdQty.ToString();
            CheckResults();
            stack.Add(score);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.btnStart_Click(null, e);
            btnCancel.Enabled = false;
            btnReset.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            stack.Delete();
            score = stack.GetLast();
            if (cmdQty > 0)
                cmdQty -= 1;
            lblNumber.Text = score.ToString();
            lblQuantity.Text = cmdQty.ToString();
            if (score == 0)
            {
                btnCommand2.Enabled = false;
                btnCancel.Enabled = false;
            }
        }

        private void CheckResults()
        {
            if (score > target)
            {
                lblResults.ForeColor = Color.Red;
                lblResults.Text = "ПЕРЕБОР!";
                lblResults.Visible = true;
                btnStart.Enabled = true;
                btnCommand1.Enabled = false;
                btnCommand2.Enabled = false;
                btnCancel.Enabled = false;
            }
            else
            {
                if (score == target)
                {
                    lblResults.ForeColor = Color.Green;
                    lblResults.Text = "ПОБЕДА!";
                    lblResults.Visible = true;
                    btnStart.Enabled = true;
                    btnCommand1.Enabled = false;
                    btnCommand2.Enabled = false;
                    btnCancel.Enabled = false;
                }
            }
        }
    }

    public class Stack
    {
        List<int> stackArray = new List<int>();

        public void Add(int score)
        {
            stackArray.Add(score);
        }

        public void Delete()
        {
            if (stackArray.Count > 0)
                stackArray.RemoveAt(stackArray.Count - 1);
        }

        public int GetLast()
        {
            if (stackArray.Count > 0)
                return stackArray.Last();
            else return 0;
        }

        public void Clear()
        {
            stackArray.Clear();
        }
    }
}
