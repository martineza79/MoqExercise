using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqExercise
{
    public class Repository : IRepository
    {
        public List<Stock> GetStocks()
        {
            // this would normally communicate with a database to return data
            var lstOfStocks = new List<Stock>();
            lstOfStocks.Add(new Stock
            {
                Ticker = "TMUS",
                Name = "T-Mobile",
                StockExchange = "NASDAQ",
                StockPrice = 62.05M
            });

            lstOfStocks.Add(new Stock
            {
                Ticker = "C",
                Name = "Citigroup",
                StockExchange = "NYSE",
                StockPrice = 52.17M
            });

            lstOfStocks.Add(new Stock
            {
                Ticker = "XOM",
                Name = "Exxon Mobile",
                StockExchange = "NYSE",
                StockPrice = 82.72M
            });

            return lstOfStocks;
        }
    }
} 

