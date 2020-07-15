using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            INumberOperations numberOperations = new Calculator();
            int t = numberOperations.Add(-2, -9);
            Console.WriteLine(t);
            Console.ReadLine();
            numberOperations = new AdvancedCalculator();
            t = numberOperations.Add(-2,-9);
            Console.WriteLine(t);
            Console.ReadLine();
        }
    }
}