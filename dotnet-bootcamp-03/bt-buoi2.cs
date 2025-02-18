using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_bootcamp_03
{
    internal class bt_buoi2
    {
        //Bài tập 1
        static public void CoundDaysToWeek()
        {
            bool notNegative = true;
            string numbOfDays = "";
            while (notNegative)
            {
                int daysInput = 0;
                Console.Write("input day(s): ");
                numbOfDays = Console.ReadLine();
                bool canConvert = int.TryParse(numbOfDays, out daysInput);
                if(canConvert && daysInput > 0)
                {
                    if (daysInput < 7) Console.WriteLine($"{daysInput} day(s)");
                    else Console.WriteLine($"{daysInput/7} week(s) {daysInput%7} day(s)"); 
                    notNegative = false;
                }
                else
                {
                    Console.WriteLine("Not an number or the number is negative.");
                }
            }
        }
        
        //Bài tập 2
        static public void TotalInvoice()
        {
            Console.Write("Input price: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input discount %: ");
            decimal discountPercent = Convert.ToDecimal(Console.ReadLine())/100;
            Console.WriteLine(discountPercent);

            decimal total = price - (price * (discountPercent));
            Console.WriteLine($"Total: {total}");
        }
    }
}
