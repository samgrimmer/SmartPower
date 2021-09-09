using System;
using System.ComponentModel;
using System.Globalization;

namespace SmartPower.Common
{
    public static class Extension
    {
        public static string ToCurrency(this decimal d, bool includeCurrencySymbol = true)
        {
            var currencyFormat = new CultureInfo(CultureInfo.CurrentCulture.ToString()).NumberFormat;

            currencyFormat.CurrencyNegativePattern = 1;

            var currency = d.ToString("C", currencyFormat);
            var suffix = ".00";

            if (currency.EndsWith(suffix))
            {
                currency = currency.Substring(0, currency.Length - suffix.Length);
            }

            return includeCurrencySymbol ? currency : currency.Replace("$", string.Empty);
        }

        public static string ToCurrency(this decimal? d, bool includeCurrencySymbol = true)
        {
            return d.HasValue ? d.Value.ToCurrency(includeCurrencySymbol) : string.Empty;
        }

        public static string GetEnumerationDescription(this Enum en)
        {
            return GetEnumerationValueDescriptionAttribute(en)?.Description ?? en.ToString();
        }

        private static DescriptionAttribute GetEnumerationValueDescriptionAttribute(Enum en)
        {
            var memInfo = en.GetType().GetMember(en.ToString());

            if (memInfo.Length > 0)
            {
                var attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs.Length > 0)
                {
                    return (DescriptionAttribute)attrs[0];
                }
            }

            return null;
        }
    }
}

