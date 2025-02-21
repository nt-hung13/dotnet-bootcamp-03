using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_bootcamp_03
{
    internal class bt_buoi2
    {

        /*
        Bài tập 1: Tính số ngày trong tuần và số ngày lẻ
        Input: 10
        Ouput: 1 tuần 3 ngày
         */
        static public void CoundDaysToWeek()
        {
            while (true)
            {
                Console.Write("Day(s): ");
                bool canConvert = int.TryParse(Console.ReadLine(), out int daysInput);
                if (canConvert && daysInput > 0)
                {
                    if (daysInput < 7) Console.WriteLine($"{daysInput} day(s)");
                    else Console.WriteLine($"{daysInput / 7} week(s) {daysInput % 7} day(s)");
                    break;
                }
                Console.WriteLine("Please input an integer.");
            }
        }

        /*
        Bài tập 2: Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá
        Input: 100$ và 20% 
        Output: 80$
         */
        static public void TotalInvoice()
        {
            while (true)
            {
                Console.Write("Price: ");
                bool priceInput = decimal.TryParse(Console.ReadLine(), out decimal priceAmount);
                Console.Write("Sale %: ");
                bool saleInput = int.TryParse(Console.ReadLine(), out int saleAmount);
                Console.WriteLine($"{priceInput} and {saleInput} and {priceAmount} and {saleAmount}");
                if ((priceInput && saleInput) && (priceAmount > 0 && saleAmount > 0))
                {
                    decimal totalDiscount = (priceAmount * saleAmount) / 100;
                    Console.WriteLine($"Amount to pay: {priceAmount - totalDiscount}");
                    break;
                }
                Console.WriteLine("Invalid input.");
            }
        }

        /*
        Bài tập 3: Chuyển đổi phút sang giờ và phút
        Input: 130 phút
        Output: 2 giờ 10 phút
         */
        static public void TimeConvertor()
        {
            while (true)
            {
                Console.Write("Minute(s): ");
                bool minuteInput = int.TryParse(Console.ReadLine(), out int minutes);
                if(minuteInput && minutes > 0)
                {
                    float _hours = (float)minutes / 60;
                    int _minutes = minutes < 60 ? 0 : minutes % 60;
                    Console.WriteLine($"{minutes} minute(s) = {_hours} hour(s) and {_minutes} minute(s)");
                    break;
                }
                Console.WriteLine("Invalid input.");
            }
        }

        /*
         * Bài tập 4: Tính tổng số tiền sau khi cộng thêm thuế VAT
         * Input: số tiền, số % VAT
         * Output: tổng số tiền thanh toán
         */
        static public void SumAmountToPay()
        {
            while (true)
            {
                Console.Write("Amount (exclude VAT): ");
                bool amountInput = int.TryParse(Console.ReadLine(),out int amount);
                Console.Write("Input % VAT: ");
                bool vatInput = int.TryParse(Console.ReadLine(), out int VAT);
                if((amountInput && vatInput) && (amount > 0 && VAT > 0))
                {
                    int amountToPay = amount + ((amount * VAT) / 100);
                    Console.WriteLine($"Amount to pay (include {VAT}% VAT): {amountToPay}");
                    break;
                }
                Console.WriteLine("Invalid input.");
            }
        }

        /*
         *Bài tập 5: Chuyển đổi đơn vị tiền tệ
         *Input: số tiền USD
         *Output: số tiền VND tương ứng
         */
        static public void MoneyExchange()
        {
            int vndExchangeRate = 25000;
            while (true)
            {
                Console.Write("USD amount: ");
                bool usdInput = float.TryParse(Console.ReadLine(), out float usdAmount);
                if (usdInput && usdAmount > 0)
                {
                    double vndAmount = usdAmount * vndExchangeRate;
                    Console.WriteLine($"{usdAmount} USD = {vndAmount} VND");
                    break;
                }
                Console.WriteLine("Invalid input.");
            }
        }

        static public string CountScoreAverage(int math, int physic, int chemis)
        {
            float averageScore = (math + physic + chemis)/3;
            string result = "";
            if (averageScore < 5) result = "Grade: Poor";
            else if (averageScore >= 5 && averageScore < 6.5) result = "Grade: Average";
            else if (averageScore >= 6.5 && averageScore < 8) result = "Grade: Good";
            else result = "Grade: Excellent";
            return result ;
        }
    }
}
