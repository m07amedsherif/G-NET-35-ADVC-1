using System;

namespace ConsoleApp2
{
    public class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(string movie, Seat seat, double price, bool is3D)
            : base(movie, TicketType.IMAX, seat, price)
        {
            Is3D = is3D;
        }

        public override double CalculateFinalPrice()
        {
            double p = Is3D ? Price + 30 : Price;
            return p * 1.14;
        }

        public override void Print()
        {
            Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} | Price: {Price} | Final: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}");
        }
    }
}