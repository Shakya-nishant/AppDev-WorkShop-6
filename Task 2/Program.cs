namespace Task_2
{
    internal class Program
    {
        // Question 1
        public delegate int Calculate(int a, int b);
        public delegate double DiscountStrategy(double a);
        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static double FestivalDiscount(double a) => a - (a * 0.2);
        public static double SeasonalDiscount(double a) => a - (a * 0.1);
        public static double NoDiscount(double a) => a;

        public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
        {
            return strategy(originalPrice);
        }

        static void Main(string[] args)
        {
            Calculate calc1 = Add;
            Console.WriteLine("Add: " + calc1(10, 5));
            Calculate calc2 = Subtract;
            Console.WriteLine("Subtract: " + calc2(10, 5));


            double originalPrice = 1000;
            Console.WriteLine("\nOriginal Price = 1000");
            Console.WriteLine("Festival Discount: " +
                CalculateFinalPrice(originalPrice, FestivalDiscount));
            Console.WriteLine("Seasonal Discount: " +
                CalculateFinalPrice(originalPrice, SeasonalDiscount));
            Console.WriteLine("No Discount: " +
                CalculateFinalPrice(originalPrice, NoDiscount));

            Console.WriteLine("Lambda Discount 30%: " +
                CalculateFinalPrice(originalPrice, p => p * 0.70));

            Console.ReadLine();
        }
    }
}