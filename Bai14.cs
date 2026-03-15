using System;
using System.Collections.Generic;

namespace Bai14_XoaSinhVienTheoID
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
                new Student { Id = 1001, Name = "Nguyễn A" },
                new Student { Id = 1002, Name = "Trần B" },
                new Student { Id = 1003, Name = "Lê C" }
            };

            Console.WriteLine("Danh sách hiện tại:");
            foreach (var s in list) Console.WriteLine($"{s.Id} - {s.Name}");

            Console.Write("\nNhập ID cần xóa: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                int removed = list.RemoveAll(s => s.Id == id);
                Console.WriteLine($"\nĐã xóa {removed} sinh viên.");
            }
            else
            {
                Console.WriteLine("\nID không hợp lệ.");
            }

            Console.WriteLine("\nDanh sách sau khi xóa:");
            foreach (var s in list) Console.WriteLine($"{s.Id} - {s.Name}");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}