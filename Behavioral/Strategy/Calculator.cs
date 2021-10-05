using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy
{
    public class Calculator
    {
        public IStrategy Strategy { get; set; }

        public static int Calculate(int a, int b, IStrategy Strategy)
        {
            return Strategy.Execute(a, b);
        }
    }
}
