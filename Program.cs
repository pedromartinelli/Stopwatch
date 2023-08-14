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
        Console.WriteLine("S = Segundos => 10s = 10 segundos");
        Console.WriteLine("M = Minutos => 1m = 60 segundos");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Quanto tempo deseja contar?");

        string data = Console.ReadLine()!.ToLower();

        int time = int.Parse(data.Substring(0, data.Length - 1));
        char type = char.Parse(data.Substring(data.Length - 1, 1));

        Console.WriteLine(time);
        Console.WriteLine(type);
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

