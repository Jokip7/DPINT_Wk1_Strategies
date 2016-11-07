using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DPINT_Wk1_Strategies
{
    public class ValueConverterViewModel : ViewModelBase
    {
        private string _fromText;

        private INumberConverter _fromConverter;
        private INumberConverter _toConverter;
        private ConverterFactory _converterFactory;

        public string FromText
        {
            get { return _fromText; }
            set
            {
                _fromText = value;
                RaisePropertyChanged("FromText");
                this.ConvertNumbers();
            }
        }

        private string _toText;
        public string ToText
        {
            get { return _toText; }
            set
            {
                _toText = value;
                RaisePropertyChanged("ToText");
            }
        }

        private string _fromConverterName;
        public string FromConverterName
        {
            get { return _fromConverterName; }
            set
            {
                _fromConverterName = value;
                _fromConverter = _converterFactory.getConverter(_fromConverterName);
                RaisePropertyChanged("FromText");
                this.ConvertNumbers();
            }
        }

        private string _toConverterName;
        public string ToConverterName
        {
            get { return _toConverterName; }
            set
            {
                _toConverterName = value;
                _toConverter = _converterFactory.getConverter(_toConverterName); 
                RaisePropertyChanged("ToText");
                this.ConvertNumbers();
            }
        }

        public ObservableCollection<string> ConverterNames { get; set; }
        public ICommand ConvertCommand { get; set; }

        public ValueConverterViewModel()
        {
            _converterFactory = new ConverterFactory();
            ConverterNames = new ObservableCollection<string>(_converterFactory.ConverterNames);

            _fromConverter = _converterFactory.getConverter("Numerical");
            _fromConverterName = "Numerical";
            _toConverter = _converterFactory.getConverter("Numerical");
            _toConverterName = "Numerical";

            FromText = "0";
            ToText = "0";

            ConvertCommand = new RelayCommand(ConvertNumbers);
        }

        private void ConvertNumbers()
        {
            try {
                int number = _fromConverter.ToNumerical(FromText);
                ToText = _toConverter.ToLocalString(number);
            }
            catch(FormatException ex)
            {
                ToText = "Error";
            }
        }

    }
}
