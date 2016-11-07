using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk1_Strategies
{
    class ConverterFactory
    {
        public IEnumerable<String> ConverterNames
        {
            get { return _converters.Keys; }
        }

        public Dictionary<string, INumberConverter> _converters;

        public ConverterFactory()
        {
            _converters = new Dictionary<string, INumberConverter>();
        }
    }
}
