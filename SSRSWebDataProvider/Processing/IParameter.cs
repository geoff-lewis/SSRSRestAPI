using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSRSWebDataProvider.Processing
{
    public interface IParameter
    {
        bool IsValidForValue(Type valueType);
        bool IsMatch(object value);
    }
}
