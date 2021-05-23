using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;


namespace WindowsFormsApp11
{
    static public class Operation // Класс со всеми операциями над числами
    {
        static public int ConvertNumber(string digit) // Конвертируем букву в число
        {
            int value = 0;
            foreach (Number number in Enum.GetValues(typeof(Number)))
            {
                if (number.ToString() == digit) value = (int)number;
            }
            return value;
        }

        static public string ConvertNumber(long digit) // Конвертируем число в букву
        {
            string value = String.Empty;
            foreach (Number number in Enum.GetValues(typeof(Number)))
            {
                if ((int)number == digit) value = number.ToString();
            }
            return value;
        }


        static public bool SystemNumberCheck(string number, int system) // Проверка числа на совместимость с системой счисления
        {
            foreach (char digit in number)
            {
                if (Char.IsDigit(digit) == true)
                {
                    if ((int)Char.GetNumericValue(digit) >= system)
                    {
                        return false;
                    }
                }
                else
                {
                    if (ConvertNumber(digit.ToString()) >= system)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static string ConvertTo10(string number, int system1, bool isDigit) // Конвертируем в 10 систему счисления
        {
            if (isDigit == true) //Целая часть
            {
                long value = 0;
                int temp = 0;
                int length = number.Length - 1;
                foreach (char digit in number)
                {
                    if (Char.IsDigit(digit) == false) value += (long)ConvertNumber(digit.ToString()) * (long)Math.Pow(system1, length - temp);
                    else value += (long)Char.GetNumericValue(digit) * (long)Math.Pow(system1, length-temp);
                    temp++;
                }
                return value.ToString();
            }
            else // Дробная часть
            {
                float value = 0;
                int temp = -1;
                foreach (char digit in number)
                {
                    if (Char.IsDigit(digit) == false) value += (float)ConvertNumber(digit.ToString()) * (float)Math.Pow(system1, temp);
                    else value += (float)Char.GetNumericValue(digit) * (float)Math.Pow(system1, temp);
                    temp--;
                }
                return Math.Round(value,8).ToString();
            }
        }


        internal static string ConvertToResult(string value, int system1, int system2) // Конвертируем число в другую систему счисления
        {
                if (value.Contains(',')) // Работа с дробным числом
                {
                    string number1 = value.Substring(0, value.IndexOf(',')); // Целая часть
                    string number2 = value.Substring(value.IndexOf(',') + 1); // Дробная часть

                    string value1 = ResultInt(number1, system1, system2);
                    string value2 = ResultFract(number2, system1, system2);
                    if (float.TryParse(value2, out float temp) == true && Convert.ToSingle(value2) < 1) value = (Convert.ToSingle(value1) + Convert.ToSingle(value2)).ToString();
                    else value = value1 + ',' + value2;
                }
                else // Работа с целым числом
                {
                    value = ResultInt(value, system1, system2);
                }
            return value;
        }

        private static string ResultInt(string value, int system1, int system2) // Вычисление целой части
        {
            if (system2 == 10) value = ConvertTo10(value, system1, true);
            else
            {
                value = ConvertTo10(value, system1, true);
                value = Del10(Convert.ToUInt32(value), system2);
            }
            return value;
        }

        private static string ResultFract(string value, int system1, int system2) // Вычисление дробной части
        {
            if (system2 == 10) value = ConvertTo10(value, system1, false);
            else
            {
                value = ConvertTo10(value, system1, false);
                value = Mult10(Convert.ToSingle(value), system2);
            }

            return value;
        }

        private static string Mult10(float value, int system2) // Подсчет дробной части числа
        {
            string number = String.Empty;
            for (int i = 0; i < 8; i++)
            {
                value = (float)Math.Round(value * system2, 5);
                if (Math.Truncate(value) >= 0 && Math.Truncate(value) < 10)
                {
                    number += Math.Truncate(value);
                    value -= (float)Math.Round(Math.Truncate(value), 5);
                }
                else if (Math.Truncate(value) >= 10)
                {
                    number += ConvertNumber((int)Math.Truncate(value));
                    value -= (float)Math.Round(Math.Truncate(value), 5);
                }
                if (value % 1 == 0) break;
            }
            return number;
        }

        private static string Del10(long value, int system2) // Перевод из 10 системы счисления в 11-16 целого числа
        {
            if (value < system2) // Число меньше системы счисления
            {
                if (value >= 10) return ConvertNumber(value).ToString();
                else return value.ToString();
            }
            else
            {
                string number = String.Empty;
                long rest = 0;
                do
                {
                    rest = value % (long)system2;
                    value /= (uint)system2;
                    number += rest.ToString();
                } while (value >= system2);

                rest = value % (long)system2;
                number += rest.ToString();

                char[] temp = number.ToCharArray();
                Array.Reverse(temp);
                value = Convert.ToInt64(new string(temp));
            }
            return value.ToString();
        }
    }
}
