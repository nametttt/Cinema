using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class TestForm : Form
    {
        private Button[,] buttons; // массив кнопок
        public TestForm()
        {
            InitializeComponent();
            AddButton();
        }

        public void AddButton()
        {
            int ROWS = 5; // количество кнопок в массиве
            int COLUMNS = 5; // количество кнопок в массиве
            buttons = new Button[ROWS, COLUMNS]; // создаем двумерный массив кнопок

            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    buttons[i, j] = new Button(); // создаем новую кнопку
                    buttons[i, j].Text = ""+ (i * COLUMNS + j + 1); // устанавливаем текст на кнопке
                    buttons[i, j].Location = new Point(10 + j * 100, 10 + i * 30); // устанавливаем положение кнопки
                    buttons[i, j].Click += Button_Click; // добавляем обработчик клика на кнопке
                    Controls.Add(buttons[i, j]); // добавляем кнопку на форму
                }
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            MessageBox.Show(button.Text);
        }
    }
}
