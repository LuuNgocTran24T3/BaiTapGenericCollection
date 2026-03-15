using System;
using System.Collections.Generic;

namespace Bai01_TaoDanhSachSoNguyen
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
            numbers.Add(10);
            numbers.Add(25);
            numbers.Add(-7);
            numbers.Add(88);
            numbers.Add(41);

            Console.WriteLine("Danh sách các số nguyên:");
            foreach (int num in numbers)
            {
                Console.Write(num + "  ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}