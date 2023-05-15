

class MyClass
{

    public static async Task Main(String[] args)
    {

        print1();
        print2();
        print3();

        Console.ReadKey();
    }

    public static async Task print1()
    {
        Task.Delay(GenerateRandom());
        Console.WriteLine("1.1");

        Task.Delay(GenerateRandom());
        Console.WriteLine("1.2");

        Task.Delay(GenerateRandom());
        Console.WriteLine("1.3");
    }

    public static async Task print2()
    {
        Task.Delay(GenerateRandom());
        Console.WriteLine("2.1");

        Task.Delay(GenerateRandom());
        Console.WriteLine("2.2");

        Task.Delay(GenerateRandom());
        Console.WriteLine("2.3");
    }

    public static async Task print3()
    {
        Task.Delay(GenerateRandom());
        Console.WriteLine("3.1");

        Task.Delay(GenerateRandom());
        Console.WriteLine("3.2");

        Task.Delay(GenerateRandom());
        Console.WriteLine("3.3");
    }


    static int GenerateRandom()
    {
        Random random = new Random();
        return random.Next(300, 2700);
    }

}