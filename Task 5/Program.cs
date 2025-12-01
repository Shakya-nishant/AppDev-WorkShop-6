namespace Task_5
{
    class CashierSales
    {
        public string CashierName { get; set; }
        public double SalesAmount { get; set; }

        public CashierSales(string name, double amount)
        {
            CashierName = name;
            SalesAmount = amount;
        }
    }

    class Applicant
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Applicant(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Song
    {
        public string Title { get; set; }
        public int DurationInSeconds { get; set; }

        public Song(string title, int duration)
        {
            Title = title;
            DurationInSeconds = duration;
        }

        public override string ToString()
        {
            int minutes = DurationInSeconds / 60;
            int seconds = DurationInSeconds % 60;
            return $"{Title} ({minutes}:{seconds:D2})";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine("=".PadRight(50, '='));


            Console.WriteLine("\n1. Supermarket Cashier Sales Report");
            var cashierList = new List<CashierSales>
            {
                new CashierSales("Amit", 12000),
                new CashierSales("Priya", 8500),
                new CashierSales("Rahul", 15000),
                new CashierSales("Sneha", 9800),
                new CashierSales("Vikram", 11000)
            };

            int totalCashiers = cashierList.Count;
            double totalSales = cashierList.Sum(c => c.SalesAmount);
            double highestSales = cashierList.Max(c => c.SalesAmount);
            double lowestSales = cashierList.Min(c => c.SalesAmount);
            double averageSales = cashierList.Average(c => c.SalesAmount);

            Console.WriteLine($"Total Cashiers       : {totalCashiers}");
            Console.WriteLine($"Total Sales of Day   : {totalSales:C}");
            Console.WriteLine($"Highest Sales        : {highestSales:C}");
            Console.WriteLine($"Lowest Sales         : {lowestSales:C}");
            Console.WriteLine($"Average Sales        : {averageSales:C}");


            Console.WriteLine("\n2. Election Commission - Applicant Age Check");
            var applicants = new List<Applicant>
            {
                new Applicant("Rohan", 17),
                new Applicant("Sita", 19),
                new Applicant("Karan", 16),
                new Applicant("Neha", 22),
                new Applicant("Arjun", 15)
            };

            bool hasUnder18 = applicants.Any(a => a.Age < 18);
            bool allAbove16 = applicants.All(a => a.Age > 16);

            Console.WriteLine($"Any applicant under 18?          : {hasUnder18}");
            Console.WriteLine($"Are ALL applicants above 16?     : {allAbove16}");


            Console.WriteLine("\n3. Music App - Song Duration Analysis");
            var songs = new List<Song>
            {
                new Song("Shape of You", 235),
                new Song("Despacito", 280),
                new Song("Believer", 204),
                new Song("Closer", 244),
                new Song("Thunder", 187),
                new Song("Havana", 217),
                new Song("Perfect", 263)
            };

            var firstSong = songs.First();
            var lastSong = songs.Last();
            var firstAbove4Min = songs.First(s => s.DurationInSeconds > 240);
            var firstAbove10Min = songs.FirstOrDefault(s => s.DurationInSeconds > 600); 

            Console.WriteLine($"First Song               : {firstSong}");
            Console.WriteLine($"Last Song                : {lastSong}");
            Console.WriteLine($"First song > 4 minutes   : {firstAbove4Min}");
            Console.WriteLine($"First song > 10 minutes  : {(firstAbove10Min == null ? "Not Found" : firstAbove10Min.ToString())}");

        }
    }
}