using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxesDemo.Models;

namespace TaxesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Tax21 ch = new Tax21();
            Console.WriteLine("T-shirt");
            ch.CalculateTax(25, 2);

            Tax6 tax6 = new Tax6();
            Console.WriteLine("Book");
            tax6.CalculateTax(25, 2);
        }
    }
}
