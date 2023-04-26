namespace MethodOverloading
{
    public class Program
    {
            public static int Add(int x, int y)
            {
                return x + y;
            }
            public static decimal Add(decimal c, decimal b)
            {
                return c + b;
            }
            public static string Add(int x, int y, bool isTrue)
            {
            var sum = 0;
            var response = "";
                if (isTrue)
                {
                sum = x + y;

                    if (sum == 1)
                    {
                    response = $"{sum} dollar.";
                    }
                    else
                    {
                    response = $"{sum} dollars.";
                    }
                }
            return response;
            }
        static void Main(string[] args)
        {

        }
    }
}
