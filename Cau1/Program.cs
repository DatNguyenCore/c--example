using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string textBoxA = "5";
            string textBoxB = "3";

            double a = ConvertStringToDouble(textBoxA);
            double b = ConvertStringToDouble(textBoxB);

            double sum = TinhTong(a, b);
            Console.WriteLine("Kết quả của phép toán " + sum.ToString());

            
            double square = TinhTongBinhPhuong(a, b);
            Console.WriteLine("Kết quả của phép toán " + square.ToString());
        }

        static double TinhTong(double a, double b) {
            return a + b;
        }

        static double TinhTongBinhPhuong(double a, double b) {
            return Math.Pow(a, 2) + Math.Pow(b, 2);
        }


        static double ConvertStringToDouble(string str)
        {
            try
            {
                double result = double.Parse(str);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return 0.0;
            }
        }
    }
}