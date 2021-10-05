namespace Patterns.Behavioral.Strategy.Pattern
{
    public class SumStrategy : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a + b;
        }
    }
}
