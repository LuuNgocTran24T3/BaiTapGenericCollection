using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai09_LoaiBoTrungLap
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

            List<int> data = new List<int> { 5, 2, 8, 5, 3, 8, 1, 9, 2, 5, 7 };

            Console.WriteLine("Danh sách gốc:     " + string.Join(" ", data));

            var unique = data.Distinct().ToList();

            Console.WriteLine("Không trùng lặp:   " + string.Join(" ", unique));

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}