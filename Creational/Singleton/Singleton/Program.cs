using System;

namespace Patterns.Creational.Singleton
{
    internal static class Program
    {
        internal static void Main()
        {
            const int number = 10;
            for(int i = 0; i < number; i++)
            {
                Calculator.GetInstance().AddNumberToMemory(1);
            }

            Console.WriteLine($"Calculator summed numbers in memory up to: {Calculator.GetInstance().GetSumOfNumbersInMemory()}");
            Calculator.GetInstance().ClearNumbersFromMemory();
        }
    }
}
