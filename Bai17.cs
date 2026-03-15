using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai17_PhanTuXuatHienNhieuNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("MSSV: 2415053122343");
            Console.WriteLine("Ten: Luu Ngoc Tran");
            Console.WriteLine("Lop: 24T3");
            Console.WriteLine();

            List<int> numbers = new List<int> { 1, 3, 4, 1, 2, 1, 5, 3, 1, 4, 2 };

            var freq = new Dictionary<int, int>();
            foreach (int n in numbers)
            {
                if (freq.ContainsKey(n)) freq[n]++;
                else freq[n] = 1;
            }

            int maxCount = freq.Values.Max();
            var mostFrequent = freq.Where(x => x.Value == maxCount).Select(x => x.Key);

            Console.WriteLine("Danh sách: " + string.Join(" ", numbers));
            Console.WriteLine($"Phần tử xuất hiện nhiều nhất ({maxCount} lần): {string.Join(", ", mostFrequent)}");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}