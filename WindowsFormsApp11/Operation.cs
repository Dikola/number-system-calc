using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{
    static public class Operation
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

        static public bool SystemNumberCheck(string number, int system) // Проверка числа на совместимость с системой счисления
        {
            foreach (char digit in number)
            {
                if (Char.IsDigit(digit) == true)
                {
                    if ((int)Char.GetNumericValue(digit) > system)
                    {
                        return false;
                    }
                }
                else
                {
                    if (ConvertNumber(digit.ToString()) > system)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static int ConvertTo10(int mainSystem, int resultSystem)
        {
            return 0;
        }

        internal static int ConvertToNumber(string number) // Конвертируем в число 
        {
            string value = String.Empty;
            foreach (char digit in number)
            {
                if (Char.IsDigit(digit) == true) value += digit.ToString();
                else value += ConvertNumber(digit.ToString());
            }
            return Convert.ToInt32(value);
        }
    }
}
