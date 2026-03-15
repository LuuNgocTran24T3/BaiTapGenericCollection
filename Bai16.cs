using System;
using System.Collections.Generic;

namespace Bai16_DemSoLanXuatHienCuaKyTu
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

            Console.Write("Nhập một chuỗi: ");
            string input = Console.ReadLine();

            Dictionary<char, int> count = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (count.ContainsKey(c))
                    count[c]++;
                else
                    count[c] = 1;
            }

            Console.WriteLine("\nKết quả:");
            foreach (var pair in count)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}