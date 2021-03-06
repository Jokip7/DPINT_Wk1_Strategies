﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk1_Strategies
{
    class NumericalNumberConverter : INumberConverter
    {
        public string ToLocalString(int number)
        {
            return number.ToString();
        }

        public int ToNumerical(string value)
        {
            return Int32.Parse(value);
        }
    }
}
