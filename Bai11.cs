using System;
using System.Collections.Generic;

namespace Bai11_LuuDanhSachSinhVien
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

            List<Student> students = new List<Student>
            {
                new Student { Id = 101, Name = "Nguyễn Văn A" },
                new Student { Id = 102, Name = "Trần Thị B" },
                new Student { Id = 103, Name = "Lê Văn C" },
                new Student { Id = 104, Name = "Phạm Thị D" }
            };

            Console.WriteLine("Danh sách sinh viên:");
            foreach (var s in students)
            {
                Console.WriteLine($"ID: {s.Id,-6} Tên: {s.Name}");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}