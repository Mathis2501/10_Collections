using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections
{
    interface IStockRepository
    {
        long NextId();

        void SaveStock(Asset asset);

        Stock LoadStock(long Id);

        List<Asset> FindAllStocks();

        void Clear();
    }
}
