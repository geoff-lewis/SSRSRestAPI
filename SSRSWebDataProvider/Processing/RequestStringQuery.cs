using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSRSWebDataProvider.Processing
{
    public class RequestStringQuery : IQuery
    {
        private IEnumerable<IParameter> m_Parameters;

        public RequestStringQuery(string requestString)
        {
            m_Parameters = new ParameterProvider(requestString).Parameters;
        }

        public bool IsMatch(object valueToMatch)
        {
            return m_Parameters.All(parameter => parameter.IsMatch(valueToMatch));
        }

        public bool IsValidForValue(Type valueType)
        {
            return m_Parameters.All(parameter => parameter.IsValidForValue(valueType));
        }
    }
}