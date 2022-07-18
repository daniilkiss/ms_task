using System;
using CSharpCalculator;

namespace UnitTesting_HomeWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            var s = new CSharpCalculator.Calculator();
            var ss = s.Multiply(1, 2);


            Console.WriteLine(ss);
            Console.ReadKey();
        }
    }
}
