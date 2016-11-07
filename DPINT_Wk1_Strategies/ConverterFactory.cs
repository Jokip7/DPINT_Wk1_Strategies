using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            _converters["Numerical"] = new NumericalNumberConverter();
            _converters["Roman"] = new RomanNumberConverter();
            _converters["Binary"] = new BinaryNumberConverter();
            _converters["Hexodecimal"] = new HexNumberConverter();
            _converters["Octal"] = new OctalNumberConverter();
        }

        public INumberConverter getConverter(string name)
        {
            INumberConverter converter;
            _converters.TryGetValue(name, out converter);
            return converter;
        }
    }
}
