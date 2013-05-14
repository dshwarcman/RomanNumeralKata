using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    public class RomanNumerals
    {
        static int[] specials = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        static string[] romanSpecials = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        public string NumToRoman(int num)
        {
            string value = "";
            for (int i = 0; i < specials.Length && num != 0; i++)
            {
                while (num >= specials[i])
                {
                    num -= specials[i];
                    value += romanSpecials[i];
                }
            }
            return value;
        }
    }
}
