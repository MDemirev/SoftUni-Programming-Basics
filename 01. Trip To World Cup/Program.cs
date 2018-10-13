using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Trip_To_World_Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            var ticketPriceForDeparture = float.Parse(Console.ReadLine());
            var ticketPriceForArrive = float.Parse(Console.ReadLine());
            var ticketPriceForFootballMatch = float.Parse(Console.ReadLine());
            var footballMatchCount = byte.Parse(Console.ReadLine());
            var percentageDiscount = byte.Parse(Console.ReadLine());

            var totalAirTicket = 6 * (ticketPriceForDeparture + ticketPriceForArrive);
            var totalTicketAfterPercentage = totalAirTicket - (totalAirTicket * percentageDiscount / 100);
            var totalFootballTicket = 6 * footballMatchCount * ticketPriceForFootballMatch;

            var totalSum = totalTicketAfterPercentage + totalFootballTicket;
            var eachFriendHasToPay = totalSum / 6;
            Console.WriteLine($"Total sum: {totalSum.ToString("0.00")} lv.");
            Console.WriteLine($"Each friend has to pay {eachFriendHasToPay.ToString("0.00")} lv.");
        }
    }
}
