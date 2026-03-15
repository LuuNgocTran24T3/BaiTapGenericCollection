using System;
using System.Collections.Generic;

namespace Bai03_TimSoLonNhat
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
                Console.WriteLine("Danh sách rỗng hoặc nhập sai!");
                goto End;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Số thứ {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int x))
                    numbers.Add(x);
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("Danh sách rỗng!");
            }
            else
            {
                int max = numbers[0];
                foreach (int val in numbers)
                    if (val > max) max = val;

                Console.WriteLine($"\nSố lớn nhất: {max}");
            }

        End:
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}