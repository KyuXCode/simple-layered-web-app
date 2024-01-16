namespace MathService;

public class FactorialService
{
    public static int GetFactorialOf(int n) {
        if(n==1||n==0) {
            return 1;
        }
        return GetFactorialOf(n) * GetFactorialOf(n-1)
        }
}
