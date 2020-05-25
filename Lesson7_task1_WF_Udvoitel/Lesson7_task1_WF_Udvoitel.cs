using System;
using System.Windows.Forms;

namespace Lesson7_task1_WF_Udvoitel
{
    static class Lesson7_task1_WF_Udvoitel
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
