using System;
using System.Collections.Generic;

namespace Bai05_XoaPhanTu
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

            List<string> students = new List<string>
            {
                "Nguyễn Văn An", "Trần Thị Bình", "Lê Hoàng Cường",
                "Phạm Minh Duy", "Hoàng Ngọc Lan"
            };

            Console.WriteLine("Danh sách ban đầu:");
            Console.WriteLine(string.Join("\n", students));
            Console.WriteLine();

            Console.Write("Nhập tên sinh viên cần xóa: ");
            string name = Console.ReadLine()?.Trim();

            if (!string.IsNullOrEmpty(name) && students.Remove(name))
            {
                Console.WriteLine($"\nĐã xóa \"{name}\" thành công.");
            }
            else
            {
                Console.WriteLine($"\nKhông tìm thấy \"{name}\".");
            }

            Console.WriteLine("\nDanh sách sau khi xóa:");
            Console.WriteLine(string.Join("\n", students));

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}