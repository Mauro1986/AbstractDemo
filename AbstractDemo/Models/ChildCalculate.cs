using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo.Models
{
    class ChildCalculate : Calculate
    {

        public override void Add(int a, int b)
        { 
            int result = a + b;
            Console.WriteLine(result);
        }

        public override void Divide(int a, int b)
        {
            int result = a / b;
            Console.WriteLine(result);
        }
    }
}
