using Strategy.Strategy;
using System;

namespace Strategy
{
    internal static class Program
    {
        internal static void Main()
        {
            Console.WriteLine($"3 + 7 = {Calculator.Calculate(3, 7, new SumStrategy())}");
            Console.WriteLine($"3 - 7 = {Calculator.Calculate(3, 7, new SubtractionStrategy())}");
            Console.WriteLine($"3 * 7 = {Calculator.Calculate(3, 7, new MultiplicationStrategy())}");
        }
    }
}
