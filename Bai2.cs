using System;
using System.Collections.Generic;

namespace Bai02_TinhTong
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

            List<int> numbers = new List<int>();

            Console.Write("Nhập số lượng phần tử: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Số lượng không hợp lệ!");
                goto End;
            }

            Console.WriteLine($"Nhập {n} số nguyên:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phần tử {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int val))
                    numbers.Add(val);
                else
                    numbers.Add(0);
            }

            int sum = 0;
            foreach (int x in numbers) sum += x;

            Console.WriteLine($"\nTổng các phần tử = {sum}");

        End:
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}