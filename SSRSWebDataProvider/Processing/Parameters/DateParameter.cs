using SSRSWebDataProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSRSWebDataProvider.Processing.Parameters
{
    public abstract class DateParameter :  IParameter
    {
        public DateParameter(string dateValueString)
        {
            DateTime dateValue;
            if (DateTime.TryParse(dateValueString.Replace("%3a", ":"),out dateValue))
            {
                ParameterValue = dateValue;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(dateValueString), dateValueString, "Expected a url encoded string that could be parsed into a date time.");
            }
        }

        protected DateTime ParameterValue { get; }

        public bool IsValidForValue(Type valueType)
        {
            return valueType.GetInterfaces().Contains(typeof(IDatedItem));
        }

        public bool IsMatch(object value)
        {
            if (!IsValidForValue(value.GetType())) throw new InvalidOperationException("Attempt to use parameter for invalid value");
            return IsMatch((IDatedItem)value);
        }

        protected abstract bool IsMatch(IDatedItem datedItem);
    }
}