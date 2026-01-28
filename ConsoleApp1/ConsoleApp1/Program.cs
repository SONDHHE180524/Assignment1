namespace ConsoleApp1
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Nhấn phím 1 để Chào, phím 2 để Tạm biệt:");

            while (true)
            {
                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.D1)
                {
                    // Step 3
                    Console.WriteLine("xin chào");
                }
                else if (key == ConsoleKey.D2)
                {
                    // Step 6
                    Console.WriteLine("tạm biệt");
                }
            }
        }
    }
}

