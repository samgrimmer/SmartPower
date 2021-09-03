using System;
using System.ComponentModel;

namespace SmartPower.Common
{
    public static class Extension
    {
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
