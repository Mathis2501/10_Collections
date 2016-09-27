using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections
{
    class StockValueComparator
    {
        public int Compare(Asset A, Asset B)
        {
            return B.GetValue().CompareTo(A.GetValue());
        }
    }
}
