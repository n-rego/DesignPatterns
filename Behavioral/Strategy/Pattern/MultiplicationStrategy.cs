namespace Patterns.Behavioral.Strategy.Pattern
{
    public class MultiplicationStrategy : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a * b;
        }
    }
}
