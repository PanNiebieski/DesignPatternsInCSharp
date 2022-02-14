using System;
using System.Windows.Data;

namespace WpfIValueConverterIsAExampleOfAdapter
{
    public class YesNoToBooleanAdapterConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, 
			object parameter, System.Globalization.CultureInfo culture)
		{
			switch (value.ToString().ToLower())
			{
				case "yes":
				case "oui":
				case "tak":
					return true;
				case "no":
				case "non":
				case "nie":
					return false;
			}
			return false;
		}

		public object ConvertBack(object value, Type targetType, 
			object parameter, System.Globalization.CultureInfo culture)
		{
			if (value is bool)
			{
				if ((bool)value == true)
					return "yes";
				else
					return "no";
			}
			return "no";
		}
	}
}
