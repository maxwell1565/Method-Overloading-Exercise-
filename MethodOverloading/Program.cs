
namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 12;
            var answer = Add(a, b);

            decimal x = 10.1m;
            var y = 12.1m;
            var decimalNum = Add(x, y);

            var totalAmount = Add(1, 1, true);

            Console.WriteLine($"Interger answer {answer}. Decimal answer {decimalNum}. Amount of money in your bank account is {totalAmount}.");

        }

        public static int Add(int a, int b)
        {
            return (a + b);
        }
        public static decimal Add(decimal a, decimal b)
        {
            return (a + b);
        }

        static string Add(int a, int b, bool dollarAmount)
        {
            var sum = a + b;
            if (dollarAmount == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (dollarAmount == true && sum == 1)
            {
                return "That's one dollar";
            }
            else if (dollarAmount == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }

    }

}