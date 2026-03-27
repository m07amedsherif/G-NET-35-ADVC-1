using System;

namespace ConsoleApp2
{
    public enum TicketType
    {
        Standard,
        VIP,
        IMAX
    }

    public struct Seat
    {
        public char Row { get; set; }
        public int Number { get; set; }

        public Seat(char row, int number)
        {
            Row = row;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Row}{Number}";
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Cinema cinema = new Cinema("Cairo Cinema");

            cinema.OpenCinema();

            // Ticket t = new Ticket("Test", 100); // ERROR: cannot create abstract class

            StandardTicket t1 = new StandardTicket("Inception", new Seat('A', 5), 80, "A5");
            VIPTicket t2 = new VIPTicket("Avengers", new Seat('B', 3), 200, true);
            IMAXTicket t3 = new IMAXTicket("Dune", new Seat('C', 2), 130, true);

            t1.Book();
            t2.Book();
            t3.Book();

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            cinema.PrintAllTickets();

            Console.WriteLine("\n--- Polymorphism: Final Price per Ticket ---");

            Ticket[] tickets = { t1, t2, t3 };

            foreach (Ticket t in tickets)
            {
                Console.WriteLine($"{t.GetType().Name} => Final Price: {t.CalculateFinalPrice():F2}");
            }

            Console.WriteLine("\n--- Extension Method: Receipt ---");
            Console.WriteLine(t2.GenerateReceipt());

            Console.WriteLine("\n--- Extension Method: Total Revenue ---");
            Console.WriteLine($"Total Revenue: {tickets.TotalRevenue():F2}");

            cinema.CloseCinema();
        }
    }
}