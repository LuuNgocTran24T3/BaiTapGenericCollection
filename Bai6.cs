using System;
using System.Collections.Generic;

namespace Bai06_KiemTraTonTai
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

            List<string> fruits = new List<string> { "táo", "chuối", "cam", "xoài", "dứa" };

            Console.WriteLine("Danh sách trái cây: " + string.Join(", ", fruits));
            Console.Write("\nNhập tên trái cây cần tìm: ");
            string search = Console.ReadLine()?.Trim().ToLower();

            if (fruits.Contains(search))
                Console.WriteLine($"→ Có \"{search}\" trong danh sách.");
            else
                Console.WriteLine($"→ Không có \"{search}\".");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}