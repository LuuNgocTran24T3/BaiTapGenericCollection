using System;
using System.Collections.Generic;

namespace Bai18_QuanLyDiemSinhVien
{
    class Student
    {
        public string Name { get; set; }
        public double Score { get; set; }
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
                new Student { Name = "Nguyễn Văn A", Score = 8.7 },
                new Student { Name = "Trần Thị B",   Score = 9.2 },
                new Student { Name = "Lê Hoàng C",   Score = 7.5 },
                new Student { Name = "Phạm Minh D",  Score = 9.5 }
            };

            Student top = null;
            double maxScore = double.MinValue;

            foreach (var s in students)
            {
                if (s.Score > maxScore)
                {
                    maxScore = s.Score;
                    top = s;
                }
            }

            Console.WriteLine("Danh sách sinh viên:");
            foreach (var s in students)
                Console.WriteLine($"{s.Name,-15} Điểm: {s.Score}");

            if (top != null)
                Console.WriteLine($"\nSinh viên có điểm cao nhất: {top.Name} - {top.Score}");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}