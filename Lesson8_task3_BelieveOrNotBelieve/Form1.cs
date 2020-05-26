﻿// Ястребов Юрий
// 3. а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок
// (не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
// б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
// в) Добавить в приложение меню «О программе» с информацией о программе(автор, версия, авторские права и др.).
// г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных(элемент SaveFileDialog).

using BelieveOrNotBelieve;
using System;
using System.Windows.Forms;

namespace Lesson8_task3_BelieveOrNotBelieve
{
    public partial class Form1 : Form
    {
        // База данных с вопросами
        TrueFalse database;

        public Form1()
        {
            InitializeComponent();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("Введите вопрос", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            };
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            tboxQuestion.Text = database[(int)nudNumber.Value - 1].text;
            cboxTrue.Checked = database[(int)nudNumber.Value - 1].trueFalse;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
        }

        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            database[(int)nudNumber.Value - 1].text = tboxQuestion.Text;
            database[(int)nudNumber.Value - 1].trueFalse = cboxTrue.Checked;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор - Ястребов Юрий\nВерсия 1.0");
        }
    }
}