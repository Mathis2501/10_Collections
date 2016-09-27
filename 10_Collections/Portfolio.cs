using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections
{
    class Portfolio
    {
        public List<Asset> Stocks = new List<Asset>();
        public Portfolio(List<Asset> stocks)
        {
            Stocks = stocks;
        }

        public Portfolio()
        {

        }

        public double GetTotalValue()
        {
            double Total = 0;
            foreach (Asset item in Stocks)
            {
                Total += item.GetValue();
            }
            return Total;
        }

        public void AddAsset(Asset OrigAsset)
        {
            Stocks.Add(OrigAsset);
        }

    }
}
