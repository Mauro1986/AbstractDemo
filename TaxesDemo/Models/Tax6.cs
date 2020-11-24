using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxesDemo.Models
{
    class Tax6 : Tax
    {
        public override void CalculateTax(int price, int nrOfArt)
        {
            double result = (price * nrOfArt) * 1.06;
            Console.WriteLine(result);
        }
    }
}
