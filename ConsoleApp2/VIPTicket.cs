using System;

namespace ConsoleApp2
{
    public class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }

        public decimal ServiceFee { get; set; } = 50;

        public VIPTicket(string movie, Seat seat, double price, bool lounge)
            : base(movie, TicketType.VIP, seat, price)
        {
            LoungeAccess = lounge;
        }

        public override double CalculateFinalPrice()
        {
            return (Price + (double)ServiceFee) * 1.14;
        }

        public override void Print()
        {
            Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | Fee: {ServiceFee} | Price: {Price} | Final: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}");
        }
    }
}