using System;
using System.Buffers;

namespace ConsoleApp2
{
    public abstract class Ticket : IPrintable, IBookable, ICloneable
    {
        private static int counter = 0;

        public int TicketId { get; private set; }

        public string MovieName { get; set; }

        public Seat Seat { get; set; }

        public double Price { get; set; }

        public bool IsBooked { get; private set; }

        public TicketType Type { get; protected set; }

        public Ticket(string movie, TicketType type, Seat seat, double price)
        {
            counter++;
            TicketId = counter;

            MovieName = movie;
            Type = type;
            Seat = seat;
            Price = price;
        }

        // ABSTRACT
        public abstract double CalculateFinalPrice();

        // VIRTUAL
        public virtual void Print()
        {
            Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | {Type} | Seat: {Seat} | Price: {Price} | Final: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        // CONCRETE
        public bool Book()
        {
            if (IsBooked) return false;

            IsBooked = true;
            return true;
        }

        public bool Cancel()
        {
            if (!IsBooked) return false;

            IsBooked = false;
            return true;
        }

        public virtual object Clone()
        {
            Ticket clone = (Ticket)this.MemberwiseClone();
            counter++;
            clone.TicketId = counter;
            clone.IsBooked = false;
            return clone;
        }
    }
}