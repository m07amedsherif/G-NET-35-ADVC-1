using System;
using System.Text;

namespace ConsoleApp2
{
    public static class TicketExtensions
    {
        public static string GenerateReceipt(this Ticket ticket)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("========== RECEIPT ==========");
            sb.AppendLine($"  Movie    : {ticket.MovieName}");
            sb.AppendLine($"  Type     : {ticket.Type}");
            sb.AppendLine($"  Price    : {ticket.Price}");
            sb.AppendLine($"  Final    : {ticket.CalculateFinalPrice():F2}");
            sb.AppendLine($"  Status   : {(ticket.IsBooked ? "Booked" : "Not Booked")}");
            sb.AppendLine("=============================");

            return sb.ToString();
        }

        public static double TotalRevenue(this Ticket[] tickets)
        {
            double total = 0;

            foreach (var t in tickets)
            {
                if (t != null && t.IsBooked)
                    total += t.CalculateFinalPrice();
            }

            return total;
        }
    }
}