using SSRSWebDataProvider.Processing.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace SSRSWebDataProvider.Processing
{
    public class ParameterSource
    {
        public static IParameter GetParameter(string parameterName, string parameterValue)
        {
            switch (parameterName)
            {
                case "FromDate":
                case "StartDate":
                    return new FromDateParameter(parameterValue);
                case "ToDate":
                case "EndDate":
                    return new ToDateParameter(parameterValue);
            }

            throw new ArgumentOutOfRangeException(nameof(parameterName), parameterName, "Cannot provide parameter for this item.");
        }
    }
}