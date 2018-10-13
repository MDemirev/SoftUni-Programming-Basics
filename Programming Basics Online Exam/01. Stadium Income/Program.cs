using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Stadium_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            var countSector = int.Parse(Console.ReadLine());

            var capacity = int.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());
            
            var total = (capacity * price) / countSector;

            var totalWin = total * countSector;
       
            var moneyForCharity = (totalWin - (total * 0.75)) / 8;

            Console.WriteLine($"Total income - {totalWin.ToString("0.00")} BGN");
            Console.WriteLine($"Money for charity - {moneyForCharity.ToString("0.00")} BGN");


        }
    }
}
