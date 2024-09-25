using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = 1;
            double y1 = 2;
            double x2 = 4;
            double y2 = 6;

            // Tính khoảng cách AB
            // A(1, 2) và điểm B(4, 6) là: 5
            double distance = KhoangCachHaiDiem(x1, y1, x2, y2);

            // In ra kết quả
            Console.WriteLine($"Khoảng cách giữa điểm A({x1}, {y1}) và điểm B({x2}, {y2}) là: {distance}");
        }


        // Hàm tính khoảng cách giữa hai điểm
        static double KhoangCachHaiDiem(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}