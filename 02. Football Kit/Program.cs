using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Football_Kit
{
    class Program
    {
        static void Main(string[] args)
        {
            var tshirPrice = float.Parse(Console.ReadLine());
            var sumForBall = float.Parse(Console.ReadLine());

            var shortPrice = tshirPrice * 0.75;
            var socksPrice = shortPrice * 0.2;
            var bootsPrice = (tshirPrice + shortPrice) * 2;
            var totalPrice = tshirPrice + shortPrice + socksPrice + bootsPrice;

            var totalPriceAfterDiscount = totalPrice - (totalPrice * 15 / 100);


            if (totalPriceAfterDiscount >= sumForBall)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {totalPriceAfterDiscount.ToString("0.00")} lv.");
            }
            else
            {                
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {(sumForBall - totalPriceAfterDiscount).ToString("0.00")} lv. more.");
            }
                    
        }
    }
}
