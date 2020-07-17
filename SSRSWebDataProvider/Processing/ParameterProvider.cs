using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSRSWebDataProvider.Processing
{
    public class ParameterProvider
    {
        public IEnumerable<IParameter> Parameters { get; private set; }

        public ParameterProvider(string queryString)
        {
            LoadParametersFromQueryString(queryString);
        }

        private void LoadParametersFromQueryString(string queryString)
        {
            var parameterNameValuePairs = queryString.Split('&').ToDictionary(nameValuePair => GetParameterName(nameValuePair), nameValuePair => GetParameterValue(nameValuePair));
            Parameters = GetParameters(parameterNameValuePairs);
        }

        private string GetParameterName(string nameValuePair)
        {
            return nameValuePair.Split('=').First(); 
        }

        private string GetParameterValue(string nameValuePair)
        {
            return nameValuePair.Split('=').Last();
        }

        private IEnumerable<IParameter> GetParameters(Dictionary<string, string> parameterNameValuePairs)
        {
            return parameterNameValuePairs.Select(parameterNameValuePair => ParameterSource.GetParameter(parameterNameValuePair.Key,parameterNameValuePair.Value));
        }

    }
}