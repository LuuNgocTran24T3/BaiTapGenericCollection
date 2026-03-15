using System;
using System.Collections.Generic;

namespace Bai13_DemSoSinhVien
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
                new Student { Id = 301, Name = "A" },
                new Student { Id = 302, Name = "B" },
                new Student { Id = 303, Name = "C" },
                new Student { Id = 304, Name = "D" },
                new Student { Id = 305, Name = "E" }
            };

            Console.WriteLine($"Tổng số sinh viên hiện có: {students.Count}");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}