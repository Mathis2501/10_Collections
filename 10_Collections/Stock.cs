using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections
{
    class Stock : Asset
    {

        public string Symbol;
        public double PricePerShare;
        public double NumShares;

        public Stock()
        {
            
        }

        public Stock(string symbol, double pricePerShare, double numShares)
        {
            Symbol = symbol;
            PricePerShare = pricePerShare;
            NumShares = numShares;
        }

        public double GetValue()
        {
            return NumShares * PricePerShare;
        }

        public static double TotalValue(Stock[] stocks)
        {
            double Total = 0;
            foreach (Stock stock in stocks)
            {
                Total += stock.NumShares * stock.PricePerShare;
            }
            return Total;
        }

        public static double TotalValue(Asset[] Stocks)
        {
            double Total = 0;
            foreach (Asset item in Stocks)
            {
                Total += item.GetValue();
            }
            return Total;
        }

        public override string ToString()
        {
            return "Stock[symbol=" + Symbol + ",pricePerShare=" + PricePerShare.ToString().Replace(",",".") + ",numShares=" + NumShares + "]";
        }

        public bool Equals(Stock stock)
        {
            if (stock.Symbol == this.Symbol && stock.PricePerShare == this.PricePerShare && stock.NumShares == this.NumShares)
                return true;
            else
                return false;
        }



    }
}
