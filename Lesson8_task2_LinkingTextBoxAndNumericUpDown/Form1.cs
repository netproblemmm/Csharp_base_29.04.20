// Ястребов Юрий
// 2.	Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown

using System;
using System.Windows.Forms;

namespace Lesson8_task2_LinkingTextBoxAndNumericUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tb1.Text = numericUpDown1.Value.ToString();
        }
    }
}
