using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public enum Number
    {
        A = 10,
        B,
        C,
        D,
        E,
        F
    }

    public partial class Form1 : Form
    {
        readonly int[] SystemItemsArray = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }; // Системы счисления
        public Form1()
        {
            InitializeComponent();
            // Инициализация списка систем счисления
            foreach (int item in SystemItemsArray)
            {
                systemSelector1.Items.Add(item);
                systemSelector2.Items.Add(item);
            }
            systemSelector1.SelectedIndex = 0;
            systemSelector2.SelectedIndex = 8;
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            mainField.Text += 0.ToString();
        }

        private void SystemChanger_Click(object sender, EventArgs e)
        { 
            // Смена систем счисления между собой
            int temp = systemSelector1.SelectedIndex;
            systemSelector1.SelectedIndex = systemSelector2.SelectedIndex;
            systemSelector2.SelectedIndex = temp;
        }

        private void MainField_KeyPress(object sender, KeyPressEventArgs e)
        { 
            // Проверка ввода символа
            char ch = e.KeyChar;
           
            if (!Char.IsDigit(ch) && !(ch >= 65 && ch <= 70) && !(ch >= 97 && ch <= 102) && !(ch == 46))
            {
                e.Handled = true;
            }
            else
            {
                // Смена букв с маленького на большой регистр
                if (ch >= 97 && ch <= 102)
                {
                    switch (ch)
                    {
                        case 'a':
                            mainField.Text += 'A';
                            break;
                        case 'b':
                            mainField.Text += 'B';
                            break;
                        case 'c':
                            mainField.Text += 'C';
                            break;
                        case 'd':
                            mainField.Text += 'D';
                            break;
                        case 'e':
                            mainField.Text += 'E';
                            break;
                        case 'f':
                            mainField.Text += 'F';
                            break;
                    }
                }
                else if ((ch == 46)) DotCheck();
                e.Handled = true;
                mainField.SelectionStart = mainField.Text.Length;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            mainField.Text += 1.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            mainField.Text += 2.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            mainField.Text += 3.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            mainField.Text += 4.ToString();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            mainField.Text += 5.ToString();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            mainField.Text += 6.ToString();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            mainField.Text += 7.ToString();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            mainField.Text += 8.ToString();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            mainField.Text += 9.ToString();
        }

        private void ButtonA_Click(object sender, EventArgs e)
        {
            mainField.Text += 'A';
        }

        private void ButtonB_Click(object sender, EventArgs e)
        {
            mainField.Text += 'B';
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            mainField.Text += 'C';
        }

        private void ButtonD_Click(object sender, EventArgs e)
        {
            mainField.Text += 'D';
        }

        private void ButtonE_Click(object sender, EventArgs e)
        {
            mainField.Text += 'E';
        }

        private void ButtonF_Click(object sender, EventArgs e)
        {
            mainField.Text +='F';
        }

        private void ButtonX_Click(object sender, EventArgs e) // Очищение поля
        {
            mainField.Clear();
        }

        private void ButtonDel_Click(object sender, EventArgs e) // Удаление последнего символа
        {
            if (mainField.Text.Length != 0) mainField.Text = mainField.Text.Remove(mainField.Text.Length - 1);
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            // Проверка на одну точку
            DotCheck();
        }

        private void DotCheck()
        {
            string str = mainField.Text;
            if (!(str.Contains('.'))) mainField.Text += '.'; ;
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            string number = mainField.Text;
            if (systemSelector1.SelectedIndex == systemSelector2.SelectedIndex) // Проверка на одинаковые системы счисления
            {
                MessageBox.Show("Выберите систему счисления, отличную от начальной.");
            }
            else if (Operation.SystemNumberCheck(number, (int)systemSelector1.SelectedItem) == false) // Проверка на значения выше системы счисления
            {
                MessageBox.Show("Ошибка, проверьте правильность ввода и выбранной системы.");
            }
            else
            {
               int value = Operation.ConvertToNumber(number);
            }
        }
    }
}
