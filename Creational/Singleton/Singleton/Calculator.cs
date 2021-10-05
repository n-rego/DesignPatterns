using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Singleton
{
    public sealed class Calculator
    {

        private static Calculator _instance;
        private readonly List<int> _memory = new();

        private Calculator()
        {

        }

        public static Calculator GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Calculator();
            }

            return _instance;
        }

        public void AddNumberToMemory(int number)
        {
            _memory.Add(number);
        }

        public void ClearNumbersFromMemory()
        {
            _memory.Clear();
        }

        public int GetSumOfNumbersInMemory()
        {
            int sum = 0;
            _memory.ForEach((number) => sum += number);

            return sum;
        }
    }
}
