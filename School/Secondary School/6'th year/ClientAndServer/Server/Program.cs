using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server
{
    internal class Program
    {
        private const string Scrambler = "#8AhGfRsnAkDB8@56SJ@{0}jaj\\/{{[]@$2nf";

        private static IPAddress host;
        private static int port;
        private static bool listening = true;

        private static void Main(string[] args)
        {
            Func<string, string> getEnv = Environment.GetEnvironmentVariable;

            string inputPort = getEnv("LAT_port");

            host = GetIp(getEnv("LAT_target"));
            port = GetPort(inputPort);
            Console.WriteLine($"Starting server on {host}:{port}");
            new Thread(StartServer).Start();
        }

        private static IPAddress GetIp(string env)
        {
            IPAddress ip;

            string ipString = env;

            if (string.IsNullOrWhiteSpace(env))
                ipString = GetConsoleUserInput("Please provide a host. (LAT_target)\r\nIP: ");

            try
            {
                ip = IPAddress.Parse(ipString);
            }
            catch (FormatException)
            {
                return GetIp(env);
            }

            return ip;
        }

        private static string GetConsoleUserInput(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) return GetConsoleUserInput(message);
            return input.Trim();
        }

        private static int GetPort(string defaultPort)
        {
            string initPort = defaultPort;
            Action performInvalid = () =>
                Console.WriteLine($"Your port number is invalid! ({defaultPort})\r\n" +
                                  "Your port must be between 0 and 65535 (included)!");

            if (string.IsNullOrWhiteSpace(defaultPort))
                defaultPort = GetConsoleUserInput("\r\nPlease provide a port for your host. (LAT_port)\r\nPORT: ");
            int port;
            try
            {
                port = int.Parse(defaultPort);
            }
            catch (FormatException)
            {
                Console.WriteLine("Your port is not a number!\r\n" +
                                  "Please select a number between 0 and 65535 (included).");
                return GetPort(initPort);
            }
            catch (OverflowException)
            {
                performInvalid();
                return GetPort(initPort);
            }
            if (port < 0 || port >= 65535)
            {
                performInvalid();
                return GetPort(initPort);
            }

            return port;
        }

        private static void StartServer()
        {
            TcpListener server = null;
            listening = true;

            try
            {
                server = new TcpListener(host, port);
                server.Start();

                byte[] bytes = new byte[1024];
                string data;
                while (listening)
                {
                    Console.WriteLine("Waiting for connection.");
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected");

                    data = null;
                    NetworkStream stream = client.GetStream();

                    int i;

                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        data = Encoding.ASCII.GetString(bytes, 0, i);
                        Console.WriteLine($"Received {data}");
                        HashHandler hashHandler = new HashHandler(data, Scrambler);
                        byte[] msg = Encoding.ASCII.GetBytes(hashHandler.GetHashSha512());
                        stream.Write(msg, 0, msg.Length);
                    }
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine($"Socket exception:\r\n{e}");
            }
            finally
            {
                server.Stop();
            }
        }
    }
}