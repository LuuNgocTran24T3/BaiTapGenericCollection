using System;
using System.Collections.Generic;

namespace Bai10_TimSoNhoNhat
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

            List<int> values = new List<int> { 45, 12, 89, 3, 67, -5, 34 };

            if (values.Count == 0)
            {
                Console.WriteLine("Danh sách rỗng!");
            }
            else
            {
                int min = values[0];
                foreach (int v in values)
                    if (v < min) min = v;

                Console.WriteLine("Danh sách: " + string.Join(" ", values));
                Console.WriteLine($"Giá trị nhỏ nhất: {min}");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}