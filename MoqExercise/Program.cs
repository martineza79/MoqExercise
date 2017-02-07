using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqExercise
{
    public class Program
    {
        public static void main(string [] args)
        {
            var concreteRepository = new Repository();
            var stockController = new StockController(concreteRepository);
        }
    }
}
