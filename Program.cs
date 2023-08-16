namespace Stopwatch;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Bem vindo! Selecione uma opção a seguir:");
        Console.WriteLine("1 - timer");
        Console.WriteLine("2 - pomodoro");
        Console.WriteLine("3 - sair da aplicação");
        short opcao = short.Parse(Console.ReadLine()!);

        switch (opcao)
        {
            case 1: Timer(); break;
            case 2: Pomodoro(); break;
            case 3: System.Environment.Exit(0); break;
            default: Menu(); break;
        }
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

        int cycleCount = 0;

        while (cycleCount < cycles)
        {
            cycleCount++;
            Start(focusTime, "Mantenha o foco!");

            if (cycleCount == cycles)
            {
                Start(restPomodoro, "Descanse para o próximo pomodoro.");
            }
            else
            {
                Start(restTime, "Descanse para o próximo ciclo.");
            }
        }

        Console.Clear();
        Console.WriteLine("Pomodoro finalizado. Aperte qualquer tecla para retornar ao menu.");
        Console.ReadKey();
        Menu();
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

        Start(time * multiplier, "");
        Console.Clear();
        Console.WriteLine("Stopwatch finalizado. Aperte qualquer tecla para retornar ao menu.");
        Console.ReadKey();
        Menu();
    }

    static void Start(int time, string? message)
    {
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();
            Console.WriteLine($"{message}");
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }
    }
}

