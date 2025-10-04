using System;
using System.Windows.Forms;

namespace Lab2
{
    public class MainForm : Form
    {
        private Button button1;
        private Label label1;

        public MainForm()
        {
            // Створюємо кнопку
            button1 = new Button();
            button1.Text = "Натисни мене";
            button1.Location = new System.Drawing.Point(50, 50);
            button1.Click += Button1_Click;

            // Створюємо мітку
            label1 = new Label();
            label1.Text = "Порожньо";
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(50, 100);

            // Додаємо елементи на форму
            Controls.Add(button1);
            Controls.Add(label1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Кнопку натиснуто!";
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}
