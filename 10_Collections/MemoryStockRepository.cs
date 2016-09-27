using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections
{
    class MemoryStockRepository : IStockRepository
    {
        private long id = 0;
        public List<Asset> assets = new List<Asset>();

        public long NextId()
        {
            id++;
            return id;

        }

        public void SaveStock(Asset a)
        {
            assets.Add(a);
        }

        public Stock LoadStock(long Id)
        {
            foreach (Stock a in assets)
            {
                if (a.Id == Id)
                {
                    return a;
                }
            }
            return null;
        }

        public List<Asset> FindAllStocks()
        {
            return assets;
        }

        public void Clear()
        {
            assets.Clear();
        }
    }
}
