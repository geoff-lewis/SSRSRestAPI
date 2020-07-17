using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSRSWebDataProvider.Models
{
    public interface IDatedItem
    {
        DateTime Date { get; }
    }
}
