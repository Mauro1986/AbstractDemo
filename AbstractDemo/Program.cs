using AbstractDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildCalculate calculate = new ChildCalculate();
            calculate.Add(2,2);
            calculate.Substract(10, 5);
            calculate.Divide(12, 6);
        }
    }
}
