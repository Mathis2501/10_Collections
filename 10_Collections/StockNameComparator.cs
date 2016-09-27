using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;


namespace _10_Collections
{
    class StockNameComparator
    {
        public int Compare(Stock A, Stock B)
        {
            return string.Compare(A.Symbol, B.Symbol);
        }
    }
}
