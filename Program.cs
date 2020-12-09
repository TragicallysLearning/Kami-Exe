using System;
using System.Threading;

namespace Console_App_Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = $"Logged In As - {Environment.UserName} | Spoofed Servers - 362 | API Count - 53 | Source - First Exe Botnet V1";

            Console.WriteLine($"//Welcome To The First Console App \"Booter\" My Homie G Gangsta Slamma Dawg\r\n//Version - 1.0");

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write($"\r\n\r\n\r\n\r\n{Environment.UserName}@exe:~# ");

            Console.ResetColor();

            string cmd = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write($"\r\n\r\nCommand Entered - {cmd}");

            Console.ResetColor();

            System.Threading.Thread.Sleep(10000);

            Console.Write("k");

        }
    }
}
