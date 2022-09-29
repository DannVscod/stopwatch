    using System;
    using System.Threading;
    namespace stopwatch
    {
        class Program
        {
        static void Main(string[] args)
        {
            Start(6);
            Menu();
        }
        static void Menu(){

            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto =>1m = 1 minuto");
            Console.WriteLine("0 = sair");
            Console.WriteLine("Quanto tempo deseja contar?  ");
            string data = Console.ReadLine().ToLower();
            char typer = Char.Parse(data.Substring(1,1));
            Console.WriteLine(data);



        }
        static void Start(int time)
        {
            
            int currentTime = 0;
            while (currentTime != time) {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
        
        
        }

        }
    }
