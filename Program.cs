using System;
using System.Threading;
using System.Net;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Console_App_Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = $"Logged In As - {Environment.UserName} | Spoofed Servers - 362 | API Count - 53";

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"//Welcome To The First Console App \"Booter\" My Homie G Gangsta Slamma Dawg\r\n//Version - 1.0");

            Console.Write("\r\x1b[0;31mUsername\x1b[0;37m: " + Environment.UserName + "\r\n");
            Console.Write("\r\x1b[0;31mPassword\x1b[0;37m: **********\r\n");
            Console.Write("\r\n");
            Console.Write("\r\n");
            Console.Write("                     ██╗  ██╗ █████╗ ███╗   ███╗██╗                \r\n");
            Console.Write("                     ██║ ██╔╝██╔══██╗████╗ ████║██║                \r\n");
            Console.Write("                     █████╔╝ ███████║██╔████╔██║██║                \r\n");
            Console.Write("                     ██╔═██╗ ██╔══██║██║╚██╔╝██║██║                \r\n");
            Console.Write("                     ██║  ██╗██║  ██║██║ ╚═╝ ██║██║                \r\n");
            Console.Write("                     ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝     ╚═╝╚═╝                \r\n");
            Console.Write("                    Type help for a list of commands!            \r\n");
            Console.Write("\r\n");

            do
            {

                Console.Write($"\r\n{Environment.UserName}@exe:~# ");

                Console.ResetColor();

                string cmd = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Red;

                if (cmd.Equals("attack", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("\r\n ╔═════╦═══════════════════╦══════════════════════════════════════════════════╦═══════════════╦═════╗\r\n");
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

                if (cmd.Equals("help", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("\r\n ╔═══════════════════════════════════╗ \r\n");
                    Console.Write(" ║ tools - Shows Tools               ║ \r\n");
                    Console.Write(" ║ attack - Shows Attack Methods     ║ \r\n");
                    Console.Write(" ║ ports - Shows Helpful ports       ║ \r\n");
                    Console.Write(" ║ isp - Shows ISP Vulns             ║ \r\n");
                    Console.Write(" ╚═══════════════════════════════════╝ \r\n");
                }

                if (cmd.Equals("clear", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    Console.Write("\r\n");
                    Console.Write("\r\n");
                    Console.Write("                     ██╗  ██╗ █████╗ ███╗   ███╗██╗                \r\n");
                    Console.Write("                     ██║ ██╔╝██╔══██╗████╗ ████║██║                \r\n");
                    Console.Write("                     █████╔╝ ███████║██╔████╔██║██║                \r\n");
                    Console.Write("                     ██╔═██╗ ██╔══██║██║╚██╔╝██║██║                \r\n");
                    Console.Write("                     ██║  ██╗██║  ██║██║ ╚═╝ ██║██║                \r\n");
                    Console.Write("                     ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝     ╚═╝╚═╝                \r\n");
                    Console.Write("                    Type help for a list of commands!            \r\n");
                    Console.Write("\r\n");
                }

                if (cmd.Equals("ping", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("\r\nIPv4@exe~# ");
                    string ip = Console.ReadLine();

                    new Process
                    {
                        StartInfo =
                        {
                            UseShellExecute = false,
                            FileName = "ping.exe",
                            Arguments = ip + " -t"
                        }
                    }.Start();
                }

                if (cmd.Equals("portscan", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("\r\nIPv4@exe~# ");
                    string ip = Console.ReadLine();

                    WebClient wc = new WebClient { };
                    string portscan = wc.DownloadString("https://api.hackertarget.com/nmap/?q=" + ip);
                    if (portscan == "Error enter single IP or Host only on Free Scan")
                    {
                        Console.Write("\r\nInvalid Host!\r\n");
                    }

                    else
                    {
                        Console.Write($"\r\n{portscan}\r\n");
                    }
                }

                if (cmd.Equals("subnetcalc", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("\r\nIPv4@exe~# ");
                    string ip = Console.ReadLine();

                    WebClient wc = new WebClient { };
                    string subnet = wc.DownloadString($"https://api.hackertarget.com/subnetcalc/?q={ip}");

                    if (subnet == "error check your api query")
                    {
                        Console.Write("\r\nInvalid Host\r\n");
                    }

                    else
                    {
                        Console.Write($"\r\n{subnet}\r\n");
                    }
                }

                if (cmd.Equals("tools", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("\r\n ╔═════╦═════════════════╦═══════════════╦═════╗\r\n");
                    Console.Write(" ║ UwU ║      Tools      ║  By Surtains. ║ UwU ║\r\n");
                    Console.Write(" ║═════╩═════════════════╬═══════════════╩═════║\r\n");
                    Console.Write(" ║ ping                  ║ Pings An IPV4       ║\r\n");
                    Console.Write(" ║ iplookup              ║ IP Lookup           ║\r\n");
                    Console.Write(" ║ portscan              ║ Portscans IP        ║\r\n");
                    Console.Write(" ║ subnetcalc            ║ Calculates A Subnet ║\r\n");
                    Console.Write(" ╚═══════════════════════╩═════════════════════╝\r\n");
                }

                if (cmd.Equals("ports", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("\r\n ╔═══════════════════════════════════╗ \r\n");
                    Console.Write(" ║ Layer 7 Ports                     ║ \r\n");
                    Console.Write(" ║ 80 - http sites                   ║ \r\n");
                    Console.Write(" ║ 443 - https sites                 ║ \r\n");
                    Console.Write(" ║ 53  - Dns                         ║ \r\n");
                    Console.Write(" ║ Game Ports                        ║ \r\n");
                    Console.Write(" ║ 3074 - Xbox                       ║ \r\n");
                    Console.Write(" ║ 9307 - Playstation                ║ \r\n");
                    Console.Write(" ║ 25565 - Minecraft                 ║ \r\n");
                    Console.Write(" ║ 5060 - RTP                        ║ \r\n");
                    Console.Write(" ║ VPS / Server Ports                ║ \r\n");
                    Console.Write(" ║ 22 - ssh                          ║ \r\n");
                    Console.Write(" ║ 23 - Telnet                       ║ \r\n");
                    Console.Write(" ║ 21 - Sftp                         ║ \r\n");
                    Console.Write(" ║ 69 - Tftp                         ║ \r\n");
                    Console.Write(" ║ 25 - Smtp                         ║ \r\n");
                    Console.Write(" ║ ISP vulns - Type isp              ║ \r\n");
                    Console.Write(" ╚═══════════════════════════════════╝ \r\n");
                }

                if (cmd.Equals("isp", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("\r\n ╔═══════════════════════════════════╗ \r\n");
                    Console.Write(" ║ UK ISP PORTS                      ║ \r\n");
                    Console.Write(" ║ 19 - Sky                          ║ \r\n");
                    Console.Write(" ║ 19 - BT                           ║ \r\n");
                    Console.Write(" ║ 111 - Virgin Media                ║ \r\n");
                    Console.Write(" ║ USA ISP PORTS                     ║ \r\n");
                    Console.Write(" ║ 53 or 19 - AT&T                   ║ \r\n");
                    Console.Write(" ║ 111 - CenturyLink                 ║ \r\n");
                    Console.Write(" ║ 19 - Charter                      ║ \r\n");
                    Console.Write(" ║ 111 or 19 - Comcast Cable         ║ \r\n");
                    Console.Write(" ║ 111 - Cox Communications          ║ \r\n");
                    Console.Write(" ║ 53 or 19 - Spectrum               ║ \r\n");
                    Console.Write(" ║ CANADA ISP PORTS                  ║ \r\n");
                    Console.Write(" ║ 19 - Bell Aliant                  ║ \r\n");
                    Console.Write(" ║ 111 - Bell Canada                 ║ \r\n");
                    Console.Write(" ║ 111 - Rogers Cable                ║ \r\n");
                    Console.Write(" ║ 123 - Videotron Ltee              ║ \r\n");
                    Console.Write(" ╚═══════════════════════════════════╝ \r\n");
                }

                if (cmd.Equals("iplookup", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("\r\nHost@exe~# ");
                    string Host = Console.ReadLine();

                    WebClient wc = new WebClient { };
                    string lookup = wc.DownloadString($"http://ip-api.com/json/{Host}?fields=16989721");
                    if (lookup == Host)
                    {
                        Console.Write("Invalid Host!");
                    }

                    else
                    {
                        JObject trace = JObject.Parse(lookup);
                        string final = $"IP - {trace["query"]}\r\nISP - {trace["isp"]}\r\nOrganization - {trace["org"]}\r\nAS - {trace["as"]}\r\nReverse DNS/Hostname - {trace["reverse"]}\r\nCity - {trace["city"]}\r\nRegion/State - {trace["regionName"]}\r\nCountry - {trace["country"]}\r\nMobile? - {trace["mobile"]}\r\nProxy/VPN? - {trace["proxy"]}\r\nHosting? - {trace["hosting"]}";
                        Console.Write($"\r\n{final}\r\n");
                    }
                }
            }
            while (true);
        }
    }
}
