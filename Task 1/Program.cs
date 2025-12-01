
namespace Task_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Rectangle r = new Rectangle();

            r.Length = 5;
            r.Breadth = 3;

            Console.WriteLine(r.ShowDetails());
            Console.WriteLine("Area: " + r.GetArea());
            Console.WriteLine("Perimeter: " + r.GetPerimeter());
        }
    }
}
