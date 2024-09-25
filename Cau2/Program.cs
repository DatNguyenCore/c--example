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

            double tong = TinhTong(a, b);
            Console.WriteLine("Kết quả của Tổng " + tong.ToString());

            
            double tru = TinhTru(a, b);
            Console.WriteLine("Kết quả của Trừ " + tru.ToString());

            
            double giaiThua = TinhGiaiThua(a);
            Console.WriteLine("Kết quả của Giai Thừa " + giaiThua.ToString());

            //  Giải phương trình bậc hai
            // 2x^2 + 4x − 6 = 0 => x1 = 1; x2 = -3
            TinhPhuongTrinhBacHai(2, 4, -6);

            // Giải phương trình bậc nhất
            // Nhập a = 2 và b = 4, kết quả sẽ là: Phương trình có nghiệm x = -2.
            // Nhập a = 0 và b = 0, kết quả sẽ là: Phương trình có vô số nghiệm.
            // Nhập a = 0 và b = 5, kết quả sẽ là: Phương trình vô nghiệm.
            TinhPhuongTrinhBacNhat(0, 5);

            // Giải hệ phương trình hai ẩn.
            // 2x + 3y = 5
            // 4x - y = 1
            // => x = 4/7; y = 9/7
            TinhHePhuongTrinhHaiAn(2, 3, 5, 4, -1, 1);
        }

        static double TinhTong(double a, double b) {
            return a + b;
        }
        
        static double TinhTru(double a, double b) {
            return a - b;
        }
        
        static double TinhGiaiThua(double n) {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * TinhGiaiThua(n - 1);
        }
        
        static void TinhPhuongTrinhBacHai(double a, double b, double c) {
            // Tính delta (b^2 - 4ac)
            double delta = b * b - 4 * a * c;

            if (a == 0)
            {
                if (b != 0)
                {
                    // Nếu a = 0, phương trình trở thành phương trình bậc 1: bx + c = 0
                    double x = -c / b;
                    Console.WriteLine($"Phương trình bậc nhất có nghiệm: x = {x}");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm (a và b đều bằng 0).");
                }
            }
            else
            {
                if (delta > 0)
                {
                    // Hai nghiệm phân biệt
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Phương trình có hai nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
                }
                else if (delta == 0)
                {
                    // Nghiệm kép
                    double x = -b / (2 * a);
                    Console.WriteLine($"Phương trình có nghiệm kép: x = {x}");
                }
                else
                {
                    // Vô nghiệm (delta < 0)
                    Console.WriteLine("Phương trình vô nghiệm (delta < 0).");
                }
            }
        }
        
        static void TinhPhuongTrinhBacNhat(double a, double b) {
            // Nếu a = 0
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phương trình có vô số nghiệm.");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
            }
            else
            {
                // Tính nghiệm
                double x = -b / a;
                Console.WriteLine($"Phương trình có nghiệm x = {x}");
            }
        }
        
        static void TinhHePhuongTrinhHaiAn(double a1, double b1, double c1, double a2, double b2, double c2)
        {
            // Tính định thức (determinant)
            double D = a1 * b2 - a2 * b1;
            double Dx = c1 * b2 - c2 * b1;
            double Dy = a1 * c2 - a2 * c1;

            if (D == 0)
            {
                if (Dx == 0 && Dy == 0)
                {
                    Console.WriteLine("Hệ phương trình có vô số nghiệm.");
                }
                else
                {
                    Console.WriteLine("Hệ phương trình vô nghiệm.");
                }
            }
            else
            {
                // Tính nghiệm
                double x = Dx / D;
                double y = Dy / D;
                Console.WriteLine($"Hệ phương trình có nghiệm (x, y) = ({x}, {y})");
            }
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