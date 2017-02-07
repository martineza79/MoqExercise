using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqExercise
{
    public class StockController 
    {
        IRepository repository;

        public StockController(IRepository repository)
        {
            this.repository = repository;
        }

        public void MethodToTest()
        {
            var stocks = this.repository.GetStocks();
            foreach (var stock in stocks)
            {
                if (stock.Ticker == "TMUS")
                {
                    Console.WriteLine("I own this stock");
                }
            }
        }
    }
}
