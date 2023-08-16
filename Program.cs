namespace Stopwatch;

class Program
{
    static void Main(string[] args)
    {
        Pomodoro();
    }

    static void Pomodoro()
    {
        Console.Clear();
        Console.WriteLine("Bem vindo ao método Pomodoro!");

        Console.WriteLine("Quantos ciclos terá seu Pomodoro?");
        short cycles = short.Parse(Console.ReadLine()!);

        Console.WriteLine("Quantos minutos deseja focar em cada ciclo?");
        int focusTime = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Quantos minutos deseja descansar entre cada ciclo?");
        int restTime = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Quantos minutos deseja descansar ao fim do Pomodoro?");
        int restPomodoro = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < cycles; i++)
        {
            Start(focusTime);
        }
    }

    static void Timer()
    {
        Console.Clear();
        Console.WriteLine("S = Segundos => 10s = 10 segundos");
        Console.WriteLine("M = Minutos => 1m = 60 segundos");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Quanto tempo deseja contar?");

        string data = Console.ReadLine()!.ToLower();

        int time = int.Parse(data.Substring(0, data.Length - 1));
        char type = char.Parse(data.Substring(data.Length - 1, 1));

        int multiplier = 1;

        if (type == 'm') multiplier = 60;
        if (time == 0) System.Environment.Exit(0);

        Start(time * multiplier);
        Console.Clear();
        Console.WriteLine("Stopwatch finalizado. Aperte qualquer tecla para retornar ao menu.");
        Console.ReadKey();
        Timer();
    }

    static void Start(int time)
    {
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }
    }
}

