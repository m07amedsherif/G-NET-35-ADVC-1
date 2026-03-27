using System;

namespace ConsoleApp2
{
    public partial class Cinema
    {
        public void PrintAllTickets()
        {
            Console.WriteLine("\n--- All Tickets (from Cinema.Reporting) ---");

            foreach (var t in tickets)
            {
                if (t != null)
                    t.Print();
            }
        }
    }
}