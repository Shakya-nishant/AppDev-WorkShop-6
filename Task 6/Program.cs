using System;
using System.Collections.Generic;
using System.Linq;

namespace TravelCompanyLINQ
{
    public class TourBooking
    {
        public string CustomerName { get; set; }
        public string Destination { get; set; }
        public double Price { get; set; }
        public int DurationInDays { get; set; }
        public bool IsInternational { get; set; }

        public TourBooking(string customer, string destination, double price, int days, bool isIntl)
        {
            CustomerName = customer;
            Destination = destination;
            Price = price;
            DurationInDays = days;
            IsInternational = isIntl;
        }

        public override string ToString()
        {
            return $"{CustomerName,-15} | {Destination,-12} | {Price,8:C} | {DurationInDays} days | {(IsInternational ? "International" : "Domestic")}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Fixed the broken line for Priya Patel
            List<TourBooking> bookings = new List<TourBooking>
            {
                new TourBooking("Aarav Sharma", "Dubai", 45000, 7, true),
                new TourBooking("Priya Patel", "Goa", 8000, 5, false),        // Fixed!
                new TourBooking("Rohan Singh", "Switzerland", 85000, 10, true),
                new TourBooking("Neha Gupta", "Kerala", 12000, 6, false),
                new TourBooking("Vikram Rao", "Singapore", 35000, 5, true),
                new TourBooking("Ananya Mehta", "Manali", 9500, 4, false),
                new TourBooking("Arjun Verma", "Bali", 28000, 8, true),
                new TourBooking("Sanya Reddy", "Shimla", 7000, 3, false)
            };

            Console.WriteLine("".PadRight(80, '='));
            Console.WriteLine(" TRAVEL COMPANY - MARKET ANALYSIS REPORT");
            Console.WriteLine("".PadRight(80, '='));

            // Original Data
            Console.WriteLine("\nAll Bookings:");
            Console.WriteLine(new string('-', 80));
            Console.WriteLine($"{"Customer",-15} | {"Destination",-12} | {"Price",8} | Duration | Type");
            Console.WriteLine(new string('-', 80));
            foreach (var b in bookings)
                Console.WriteLine(b);

            // FILTER 1: Tours above Rs. 10,000
            var expensiveTours = bookings.Where(t => t.Price > 10000);
            Console.WriteLine("\n\n1. Tours costing more than ₹10,000:");
            Console.WriteLine(new string('-', 80));
            foreach (var tour in expensiveTours)
                Console.WriteLine(tour);

            // FILTER 2: Tours with duration more than 4 days
            var longTours = bookings.Where(t => t.DurationInDays > 4);
            Console.WriteLine("\n\n2. Tours with duration more than 4 days:");
            Console.WriteLine(new string('-', 80));
            foreach (var tour in longTours)
                Console.WriteLine(tour);

            // BONUS: Combined filters + useful summaries
            Console.WriteLine("\n\nBonus Summary:");
            Console.WriteLine(new string('-', 60));
            Console.WriteLine($"Total Bookings           : {bookings.Count()}");
            Console.WriteLine($"Expensive Tours (>₹10,000): {expensiveTours.Count()}");
            Console.WriteLine($"Long Duration (>4 days)  : {longTours.Count()}");
            Console.WriteLine($"International Tours      : {bookings.Count(t => t.IsInternational)}");
            Console.WriteLine($"Total Revenue            : {bookings.Sum(t => t.Price):C}");
            Console.WriteLine($"Average Tour Price       : {bookings.Average(t => t.Price):C}");

            var mostExpensive = bookings.OrderByDescending(t => t.Price).First();
            Console.WriteLine($"Most Expensive Tour      : {mostExpensive.Price:C} - {mostExpensive.Destination} (by {mostExpensive.CustomerName})");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}