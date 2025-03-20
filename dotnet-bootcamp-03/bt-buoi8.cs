using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_bootcamp_03
{
    internal class bt_buoi8
    {
        /*
        * Bài 1: Tính tổng mảng
        * INPUT: [20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20]
        * OUTPUT: tổng của mảng
         */
        static public void SumOfArray()
        {
            int result = 0;
            int[] array = [20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20];
            foreach (int i in array)
                result += i;
            Console.WriteLine(result);
        }

        /*
         * Bài 2: Tìm hai số trong tổng danh sách số nguyên sao cho tổng
         * bằng một giá trị cho trước
         * INPUT: [2,7,11,15] / TARGET: 9
         * OUTPUT: [2,7] => index 0 và 1
         */
        static public void FindTargetInArray(int[] array, int target)
        {
            bool stopOuterLoop = false;
            string result = "";
           for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == target)
                    {
                        result += $"[{i}: {array[i]}, {j}: {array[j]}]";
                        stopOuterLoop = true;
                        break;
                    }
                }
                if (stopOuterLoop) break;
            }
            Console.WriteLine(result != "" ? result : "no result");
        }
        
        /*
         * Bài 3: Loại bỏ phần tử trùng lặp trong mảng số nguyên
         * INPUT: [1,2,2,3,4,6,6]
         * OUTPUT: [1,2,3,4,6]
         */
        static public List<int> RemoveDups(int[] arr)
        {
            if (arr.Length == 0) return [0];
            List<int> newArr = new List<int>();
            for (int i = 0;i < arr.Length;i++)
            {
                if (newArr.Contains(arr[i])) continue;
                newArr.Add(arr[i]);
            }
            return newArr;
        }

        /*
         * Bài 4: Tìm phần tử K xuất hiện nhiều nhất, với K là số lượng phần tử tìm. Nếu có 2 phần tử
         * cùng tần suất thì chỉ cần chọn 1 trong 2 phần tử
         * INPUT:[1, 1, 1, 2, 2, 3], K=2
         * OUTPUT =[1,2]
         * 
         */
        static public void FindMostRepeatedValue(int[] arr, int k)
        {
            if (k > arr.Length) return;
            if (arr.Length == 0) return;

            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            List<int> result= new List<int>();

            foreach(int i in arr)
            {
                if(!keyValuePairs.ContainsKey(i)) keyValuePairs.Add(i, 0);
                keyValuePairs[i]++;
            }
            result = keyValuePairs.OrderByDescending(item => item.Value)
            .ThenBy(item => item.Key) 
            .Take(k)
            .Select(item => item.Key)
            .ToList();
            
            Console.WriteLine(string.Join(", ",result));
        }

        /* Bài 5:  tìm giá trị lớn nhất từ viêc mua và bán cổ phiếu
         * INPUT: [7, 1, 5, 3, 6, 9]
         * OUTPUT: mua vào ngày 2 với giá trị 1
         *         bán vào ngày 6 với giá trị 9
         *         => lời 8
         */
        static public void BuySellStock(int[] arr)
        {
            if (arr.Length == 0) return;

            int minPrice = arr[0], minIndex = 0;
            int maxProfit = 0, buyDay = 0, sellDay = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minPrice)
                {
                    minPrice = arr[i];
                    minIndex = i;
                }
                else if (arr[i] - minPrice > maxProfit)
                {
                    maxProfit = arr[i] - minPrice;
                    buyDay = minIndex;
                    sellDay = i;
                }
            }

            if (maxProfit == 0) Console.WriteLine("No profitable trade possible.");
            else
            {
                Console.WriteLine($"Buy on day {buyDay + 1} at price {arr[buyDay]}");
                Console.WriteLine($"Sell on day {sellDay + 1} at price {arr[sellDay]}");
                Console.WriteLine($"Max Profit: {maxProfit}");
            }
        }
    }
}
