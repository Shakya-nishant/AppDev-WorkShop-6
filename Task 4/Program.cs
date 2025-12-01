using System;

namespace Task_4
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            var squared = numbers.Select(n => n * n).ToList();

            Console.WriteLine("1. Squared Numbers:");
            squared.ForEach(n => Console.WriteLine(n));
            Console.WriteLine();

            // 2. Filtering
            List<Book> books = new List<Book>
            {
                new Book { Title = "C# Basics", Price = 800 },
                new Book { Title = "Advanced C#", Price = 1500 },
                new Book { Title = "LINQ Mastery", Price = 1200 },
                new Book { Title = "Intro to AI", Price = 950 }
            };

            var premiumBooks = books.Where(b => b.Price > 1000)
                                          .Select(b => new { b.Title, b.Price })
                                          .ToList();

            Console.WriteLine("2. Premium Books (Price > 1000):");
            premiumBooks.ForEach(b => Console.WriteLine($"{b.Title} - Rs. {b.Price}"));
            Console.WriteLine();

            // 3. Sorting
            List<Student> students = new List<Student>
            {
                new Student { Name = "Nishant" },
                new Student { Name = "Aarav" },
                new Student { Name = "Binita" },
                new Student { Name = "Saurav" },
                new Student { Name = "Kushal" },
                new Student { Name = "Prakriti" },
                new Student { Name = "Anish" },
                new Student { Name = "Riya" },
                new Student { Name = "Meera" },
                new Student { Name = "Bibek" }
            };

            var sortedStudents = students.OrderBy(s => s.Name).ToList();

            Console.WriteLine("3. Students Sorted Alphabetically:");
            sortedStudents.ForEach(s => Console.WriteLine(s.Name));

        }
    }

    public class Book
    {
        public string Title { get; set; }
        public double Price { get; set; }
    }

    public class Student
    {
        public string Name { get; set; }
    }
}