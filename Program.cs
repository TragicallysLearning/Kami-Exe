using System;
using System.Threading;
using System.Net;
using System.IO;

namespace Console_App_Test_1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Title = $"Logged In As - {Environment.UserName} | Spoofed Servers - 362 | API Count - 53";

            Console.WriteLine($"//Welcome To The First Console App \"Booter\" My Homie G Gangsta Slamma Dawg\r\n//Version - 1.0");

            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write($"\r\n\r\n\r\n\r\n{Environment.UserName}@exe:~# ");

            Console.ResetColor();

            string cmd = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;

            if (cmd.Equals("help", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write(" ╔═════╦═══════════════════╦══════════════════════════════════════════════════╦═══════════════╦═════╗\r\n");
                Console.Write(" ║ UwU ║     Methods       ║       With Examples, Description & Methods       ║  By Surtains. ║ UwU ║\r\n");
                Console.Write(" ╠═════╩════╦══════════════╩════════════════╦═════════════════════════════════╩═══════════════╩═════╣\r\n");
                Console.Write(" ║ xmas     ║ xmas 1.1.1.1 5 dport=53       ║ XMAS - Basic Mix-Xmas Flood To Target                 ║\r\n");
                Console.Write(" ║ ack      ║ ack 1.1.1.1 5 dport=20        ║ ACK - ACK Flood To Target                             ║\r\n");
                Console.Write(" ║ greip    ║ greip 1.1.1.1 5 dport=PORT    ║ GREIP - GRE IP Flood To Targets                       ║\r\n");
                Console.Write(" ║ dns      ║ dns 1.1.1.1 5 dport=PORT      ║ DNS - DNS Resolver Flood Using The Targets Domain     ║\r\n");
                Console.Write(" ║ syn      ║ syn 1.1.1.1 5 dport=PORT      ║ SYN - SYN Flood To Target                             ║\r\n");
                Console.Write(" ║ stomp    ║ stom 1.1.1.1 5 dport=PORT     ║ STOMP - STOMP Flood To Target                         ║\r\n");
                Console.Write(" ║ udpplain ║ udpplain 1.1.1.1 5 dport=PORT ║ UDPPLAIN - UDP Flood With Less Options.               ║\r\n");
                Console.Write(" ║ std      ║ std 1.1.1.1 5 dport=PORT      ║ STD - STD Flood To Target                             ║\r\n");
                Console.Write(" ║ udp      ║ udp 1.1.1.1 5 dport=PORT      ║ UDP - Basic UDP Flood To Target                       ║\r\n");
                Console.Write(" ║ vse      ║ vse 1.1.1.1 5 dport=PORT      ║ VSE - Valve Source Engine specific Flood To Target    ║\r\n");
                Console.Write(" ╠════════╦═════════════════════════════════╩════╦═════════════════════════════════════════╦════════╣\r\n");
                Console.Write(" ║  Rawr. ║  Example: METHOD IP TIME dport=PORT  ║  Example: udp 66.66.75.107 60 dport=80  ║  Rawr. ║\r\n");
                Console.Write(" ╚════════╩══════════════════════════════════════╩═════════════════════════════════════════╩════════╝\r\n");
            }

            else if (cmd.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Bye! :c");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("3...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("2..");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("1.");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Now Exiting...");
                System.Threading.Thread.Sleep(1000);
                Environment.Exit(0);
            }

            if (cmd.Equals("tools", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write(" ╔═════╦═════════════════╦═══════════════╦═════╗\r\n");
                Console.Write(" ║ UwU ║      Tools      ║  By Surtains. ║ UwU ║\r\n");
                Console.Write(" ║═════╩═════════════════╬═══════════════╩═════║\r\n");
                Console.Write(" ║ ping                  ║ Pings An IPV4       ║\r\n");
                Console.Write(" ║ iplookup              ║ IP Lookup           ║\r\n");
                Console.Write(" ║ portscan              ║ Portscans IP        ║\r\n");
                Console.Write(" ║ whois                 ║ WHOIS Search        ║\r\n");
                Console.Write(" ║ traceroute            ║ Traceroute On IP    ║\r\n");
                Console.Write(" ║ resolve               ║ Resolves A Website  ║\r\n");
                Console.Write(" ║ reversedns            ║ Finds DNS Of IP     ║\r\n");
                Console.Write(" ║ asnlookup             ║ Finds ASN Of IP     ║\r\n");
                Console.Write(" ║ subnetcalc            ║ Calculates A Subnet ║\r\n");
                Console.Write(" ║ zonetransfer          ║ Shows ZoneTransfer  ║\r\n");
                Console.Write(" ╚═══════════════════════╩═════════════════════╝\r\n");
            }

            else
            {
                Console.Write("Invalid Command.");
            }
        }
    }
}
