using System;
using System.Collections.Generic;

namespace Bai12_TimSinhVienTheoTen
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

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

            List<Student> list = new List<Student>
            {
                new Student { Id = 201, Name = "Hoàng Minh" },
                new Student { Id = 202, Name = "Ngọc Lan" },
                new Student { Id = 203, Name = "Đức Anh" },
                new Student { Id = 204, Name = "Thị Hồng" }
            };

            Console.Write("Nhập tên cần tìm (không phân biệt hoa thường): ");
            string keyword = Console.ReadLine()?.Trim().ToLower();

            bool found = false;
            Console.WriteLine("\nKết quả tìm kiếm:");
            foreach (var s in list)
            {
                if (s.Name.ToLower().Contains(keyword))
                {
                    Console.WriteLine($"ID: {s.Id} - Tên: {s.Name}");
                    found = true;
                }
            }

            if (!found) Console.WriteLine("Không tìm thấy sinh viên nào.");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}