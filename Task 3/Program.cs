namespace Task_3
{
    public class Program
    {
        public static void ProcessNumbers(int[] numbers, Func<int, bool> condition, string title)
        {
            Console.WriteLine(title);
            foreach (var num in numbers)
            {
                if (condition(num))
                    Console.WriteLine(num);
            }
            Console.WriteLine();
        }
        public static void Main()
        {
            int[] nums = { 3, 8, 12, 5, 20, 1, 15 };
            ProcessNumbers(nums, n => n % 2 == 0, "Even numbers:");
            ProcessNumbers(nums, n => n > 10, "Numbers greater than 10:");
        }
    }
}