using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk1_Strategies
{
    class BinaryNumberConverter : INumberConverter
    {
        public string ToLocalString(int number)
        {
            return Convert.ToString(number, 2);
        }

        public int ToNumerical(string value)
        {
            return Convert.ToInt32(value, 2);
        }
    }
}
