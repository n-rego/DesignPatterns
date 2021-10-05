using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy
{
    public class SubtractionStrategy : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a - b;
        }
    }
}
