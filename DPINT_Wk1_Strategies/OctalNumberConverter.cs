using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk1_Strategies
{
    class OctalNumberConverter : INumberConverter
    {
        public string ToLocalString(int number)
        {
            return Convert.ToString(number, 8);
        }

        public int ToNumerical(string value)
        {
            return Convert.ToInt32(value, 8);
        }
    }
}
