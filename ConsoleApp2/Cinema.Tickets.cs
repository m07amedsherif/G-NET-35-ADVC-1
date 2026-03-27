using System;

namespace ConsoleApp2
{
    public partial class Cinema
    {
        private Ticket[] tickets = new Ticket[20];
        private Projector projector = new Projector();

        public string CinemaName { get; set; }

        public Cinema(string name)
        {
            CinemaName = name;
        }

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return true;
                }
            }
            return false;
        }

        public void OpenCinema()
        {
            Console.WriteLine("=== Cinema Opened ===");
            projector.Start();
        }

        public void CloseCinema()
        {
            Console.WriteLine("\n=== Cinema Closed ===");
            projector.Stop();
        }
    }
}