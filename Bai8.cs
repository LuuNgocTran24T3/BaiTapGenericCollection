using System;
using System.Collections.Generic;

namespace Bai08_DaoNguocDanhSach
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

            List<int> nums = new List<int> { 1, 3, 5, 7, 9, 2, 4, 6, 8 };

            Console.WriteLine("Trước khi đảo:");
            Console.WriteLine(string.Join(" ", nums));

            nums.Reverse();

            Console.WriteLine("\nSau khi đảo ngược:");
            Console.WriteLine(string.Join(" ", nums));

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}