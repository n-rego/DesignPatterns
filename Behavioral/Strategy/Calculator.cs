using Patterns.Behavioral.Strategy.Pattern;

namespace Patterns.Behavioral.Strategy
{
    public static class Calculator
    {
        public static int Calculate(int a, int b, IStrategy Strategy)
        {
            return Strategy.Execute(a, b);
        }
    }
}
