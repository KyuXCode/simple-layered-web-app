namespace MathService
{
    public class FactorialService
    {
        public static int GetFactorialOf(int n) 
        {
            if( n < 0)
            {
                throw new ArgumentException("Can't get factorial of a negative integer.");

            }

            if(n == 0 || n == 1) 
            {
                return 1;
            }
            return n * GetFactorialOf(n - 1);
        }
    }
}
