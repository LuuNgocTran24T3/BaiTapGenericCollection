using System;
using System.Collections.Generic;

namespace Bai07_SapXepDanhSach
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

            List<int> scores = new List<int> { 78, 92, 65, 88, 55, 99, 71, 84 };

            Console.WriteLine("Trước khi sắp xếp:");
            Console.WriteLine(string.Join(" ", scores));

            scores.Sort();

            Console.WriteLine("\nSau khi sắp xếp tăng dần:");
            Console.WriteLine(string.Join(" ", scores));

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}