using System;
using System.Collections.Generic;

namespace Bai15_SuDụngDictionary
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

            Dictionary<string, string> dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "hello", "xin chào" },
                { "book", "quyển sách" },
                { "cat", "con mèo" },
                { "dog", "con chó" },
                { "sun", "mặt trời" },
                { "water", "nước" }
            };

            Console.Write("Nhập từ tiếng Anh cần tra: ");
            string word = Console.ReadLine()?.Trim();

            if (!string.IsNullOrEmpty(word) && dict.TryGetValue(word, out string meaning))
            {
                Console.WriteLine($"{word} → {meaning}");
            }
            else
            {
                Console.WriteLine("Không tìm thấy từ này trong từ điển.");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}