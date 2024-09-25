using System;
using System.Timers;

namespace HelloWorld
{
    class Program
    {
        private static System.Timers.Timer stopwatchTimer;
        private static TimeSpan elapsedTime;
        private static bool isRunning = false;


        static void Main(string[] args)
        {
            stopwatchTimer = new System.Timers.Timer(1000);
            stopwatchTimer.Elapsed += OnTimedEvent;

            Console.WriteLine("Chương trình Đồng Hồ Bấm Giờ và Lịch");
            Console.WriteLine("1. Bắt đầu bấm giờ");
            Console.WriteLine("2. Tạm dừng bấm giờ");
            Console.WriteLine("3. Đặt lại bấm giờ");
            Console.WriteLine("4. Hiển thị thời gian hiện tại");
            Console.WriteLine("5. Thoát");

            while (true)
            {
                Console.Write("\nNhập lựa chọn của bạn (1-5): ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        StartStopwatch();
                        break;
                    case "2":
                        PauseStopwatch();
                        break;
                    case "3":
                        ResetStopwatch();
                        break;
                    case "4":
                        ShowCurrentTime();
                        break;
                    case "5":
                        Console.WriteLine("Thoát chương trình.");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại.");
                        break;
                }
            }
        }

        private static void StartStopwatch()
        {
            if (!isRunning)
            {
                stopwatchTimer.Start();
                isRunning = true;
                Console.WriteLine("Bắt đầu bấm giờ...");
            }
            else
            {
                Console.WriteLine("Bấm giờ đang chạy.");
            }
        }

        private static void PauseStopwatch()
        {
            if (isRunning)
            {
                stopwatchTimer.Stop();
                isRunning = false;
                Console.WriteLine($"Bấm giờ đã tạm dừng. Thời gian đã trôi qua: {elapsedTime}");
            }
            else
            {
                Console.WriteLine("Bấm giờ chưa bắt đầu.");
            }
        }

        private static void ResetStopwatch()
        {
            stopwatchTimer.Stop();
            elapsedTime = TimeSpan.Zero;
            isRunning = false;
            Console.WriteLine("Bấm giờ đã được đặt lại.");
        }

        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1));
            Console.WriteLine($"Thời gian đã trôi qua: {elapsedTime}");
        }

        private static void ShowCurrentTime()
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine($"Thời gian hiện tại: {currentTime}");
        }
    }
}