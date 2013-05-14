using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    public class RomanNumerals
    {
        public string oneToThree(int num)
        {
            if (num == 1)
                return "I";
            else if (num == 2)
                return "II";
            else
                return "III";
        }
    }
}
