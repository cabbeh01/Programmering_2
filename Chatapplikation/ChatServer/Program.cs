using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    class Program
    {
        static TcpListener listener;
        static TcpClient client;
        static int port = 3333;

        static void Main(string[] args)
        {
            StartServer();
            UserInput();
        }

        static void StartServer()
        {
            try
            {
                listener = new TcpListener(IPAddress.Any, port);
                listener.Start();
                Console.WriteLine("Server started at localhost:3333");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            StartHandshake();
        }

        static async void StartHandshake()
        {
            try
            {
                client = await listener.AcceptTcpClientAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            StartReading(client);
        }

        static async void StartReading(TcpClient k)
        {
            byte[] buffert = new byte[1024];

            int n = 0;
            try
            {
                n = await k.GetStream().ReadAsync(buffert, 0, buffert.Length);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Sending data beck to users
            SendMessage(Encoding.Unicode.GetString(buffert,0,n));


            StartReading(k);
        }

        static void SendMessage(string text)
        {
            Console.WriteLine(text);
            Broadcast(text);
        }

        static async void Broadcast(string data)
        {

        }

        static void UserInput()
        {
            try
            {
                Console.Write(">");
                string data = Console.ReadLine();
                if (string.IsNullOrEmpty(data))
                {
                    UserInput();
                }
                data.Remove(0, 1);
                string[] dataSplice = data.Split();
                switch (dataSplice[0].ToLower())
                {
                    case "kick":
                        Console.WriteLine($"Nu kickar vi användaren {dataSplice[1]}");
                        break;

                    case "exit":
                        Console.WriteLine("Shutting down");
                        Environment.Exit(0);
                        break;
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            UserInput();
        }
    }
}
