using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kom_lab1
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
            InitializeInfoContent();
        }
        private void InitializeInfoContent()
        {
            RichTextBox infoBox = new RichTextBox
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                BackColor = SystemColors.Window
            };


            infoBox.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            infoBox.AppendText("Программа:\n");
            infoBox.SelectionFont = new Font("Arial", 11, FontStyle.Regular);
            infoBox.AppendText("Разработчик: Вашурина С.И.\n\n");

            infoBox.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            infoBox.AppendText("Описание:\n");

            infoBox.SelectionFont = new Font("Arial", 11, FontStyle.Regular);
            infoBox.AppendText("Эта программа представляет собой компилятор, который переводит исходный код с языка высокого уровня в машинный код. Компилятор выполняет анализ кода, проверяет его на ошибки и формирует исполняемый файл.\n\n");

            this.Controls.Add(infoBox);
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
