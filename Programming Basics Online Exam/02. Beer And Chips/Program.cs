using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Beer_And_Chips
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var budget = double.Parse(Console.ReadLine());
            var bottlesBeers = int.Parse(Console.ReadLine());
            var chipsPackages = int.Parse(Console.ReadLine());

            var totalBeerPrice = 1.20 * bottlesBeers;
            var chipsPrice = totalBeerPrice * 45 / 100;
            var totalChipsPrice = chipsPrice * chipsPackages;
            totalChipsPrice = Math.Ceiling(totalChipsPrice);

            var totalPrice = totalBeerPrice + totalChipsPrice;
            var money = 0.0;

            if (totalPrice <= budget)
            {
                money = budget - totalPrice;
                Console.WriteLine($"{name} bought a snack and has {money.ToString("0.00")} leva left.");
            }
            else
            {
                money = totalPrice - budget;
                Console.WriteLine($"{name} needs {money.ToString("0.00")} more leva!");
            }
           
                
            
        }
    }
}
