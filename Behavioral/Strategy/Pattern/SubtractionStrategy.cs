namespace Patterns.Behavioral.Strategy.Pattern
{
    public class SubtractionStrategy : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a - b;
        }
    }
}
