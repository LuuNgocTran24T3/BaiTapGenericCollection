using System;
using System.Collections.Generic;

namespace Bai04_DemSoChan
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

            List<int> numbers = new List<int> { 4, 17, 8, -6, 22, 9, 10, 33 };

            int count = 0;
            foreach (int x in numbers)
                if (x % 2 == 0) count++;

            Console.WriteLine("Danh sách: " + string.Join(" ", numbers));
            Console.WriteLine($"→ Có {count} số chẵn.");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}