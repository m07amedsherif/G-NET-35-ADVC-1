using System;

namespace ConsoleApp2
{
    public class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }

        public StandardTicket(string movie, Seat seat, double price, string seatNumber)
            : base(movie, TicketType.Standard, seat, price)
        {
            SeatNumber = seatNumber;
        }

        public override double CalculateFinalPrice()
        {
            return Price * 1.14;
        }

        public override void Print()
        {
            Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | Standard | Seat: {SeatNumber} | Price: {Price} | Final: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}");
        }
    }
}