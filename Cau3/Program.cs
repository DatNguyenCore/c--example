using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo mảng
            double[] numbers = { 1, 2, 3, 4, 5 };

            TinhTongCaPhanTuTrongMang(numbers);

            TinhTongCaPhanTuLeTrongMang(numbers);

            SapXepMangTheoThuTuGiamDan(numbers);
        }

        static void TinhTongCaPhanTuTrongMang(double[] array) {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            // In ra kết quả
            Console.WriteLine($"Tổng các phần tử trong mảng là: {sum}");
        }

        static void TinhTongCaPhanTuLeTrongMang(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0) // Kiểm tra nếu phần tử là lẻ
                {
                    sum += array[i];
                }
            }
            
            Console.WriteLine($"Tổng các phần tử Lẻ trong mảng là: {sum}");
        }

        
        static void SapXepMangTheoThuTuGiamDan(double[] array)
        {
            // Đảo ngược mảng để có thứ tự giảm dần
            Array.Reverse(array);

            // In ra kết quả
            Console.WriteLine("Mảng sau khi sắp xếp theo thứ tự giảm dần:");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }

        }

    }
}