namespace ConsoleApp1
{
    using System;

    class Program
    {
        static void Main() {
            Console.WriteLine("Nhấn phím 1 để Chào, phím 2 để Tạm biệt:");
            while (true) {
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.D1) {
                    Console.WriteLine("xin chào");   // Step 3
                } else if (key == ConsoleKey.D2) {
                    Console.WriteLine("tạm biệt");   // Step 6
                }
            }
        }
    }
}

