using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    public class RomanNumerals
    {
        public string oneToEight(int num)
        {
            if (num == 0)
                return "";
            else if (num >= 8)
                return "X";
            else if (num > 4)
                return "V" + oneToEight(num - 5);
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
