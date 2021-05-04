using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }


        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Sec = Segundo");
            Console.WriteLine("Min = Minuto");
            Console.WriteLine("Mil = Milissegundo");
            Console.WriteLine("0 = Sair");
            Console.Write("Tempo: ");

            string data = Console.ReadLine().ToLower();
            string type = (data.Substring(data.Length - 3, 1));
            type = type + (data.Substring(data.Length - 2, 1));
            type = type + (data.Substring(data.Length - 1, 1));
            Console.WriteLine(type);

            int time = int.Parse(data.Substring(0, data.Length - 3));
            int mult = 1;

            if (time == 0)
                System.Environment.Exit(0);

            if (type == "min")
                mult = 60;

            if (type == "mil")
                StartMil(time);

            Start(time * mult);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1250);

            Start(time);
        }

        static void Start(int time)
        {
            //while (time >= 0)
            int currentTime = -1;
            while (time != currentTime)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Acabou o tempo");
            Thread.Sleep(2500);
            Console.ReadKey();
            Menu();

        }

        static void StartMil(int time)
        {
            int currentTime = -1;
            while (time != currentTime)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(500);
            }

            Console.Clear();
            Console.WriteLine("Acabou o tempo");
            Thread.Sleep(2500);
            Console.ReadKey();
            Menu();
        }

    }
}
