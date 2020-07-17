using SSRSWebDataProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSRSWebDataProvider.Processing.Parameters
{
    public class ToDateParameter : DateParameter
    {
        public ToDateParameter(string dateValueString) : base(dateValueString)
        {
        }

        protected override bool IsMatch(IDatedItem datedItem)
        {
            return datedItem.Date <= ParameterValue;
        }
    }
}