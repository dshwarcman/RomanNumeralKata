using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    public class RomanNumerals
    {
        public string NumToRoman(int num)
        {
            if (num == 0)
                return "";
            if (num == 9)
                return "IX";
            else if (num > 8)
                return "X" + NumToRoman(num - 10);
            else if (num > 4)
                return "V" + NumToRoman(num - 5);
            else if (num == 4)
                return "IV";
            else if (num == 1)
                return "I";
            else if (num == 2)
                return "II";
            else
                return "III";
        }
    }
}
