

class MyClass
{

    public static async Task Main(String[] args)
    {

        await print1();
        await print2();
        await print3();

        Console.ReadKey();
    }

    public static async Task print1()
    {
        await Task.Delay(GenerateRandom());
        Console.WriteLine("1.1");

        await Task.Delay(GenerateRandom());
        Console.WriteLine("1.2");

        await Task.Delay(GenerateRandom());
        Console.WriteLine("1.3");
    }

    public static async Task print2()
    {
        await Task.Delay(GenerateRandom());
        Console.WriteLine("2.1");

        await Task.Delay(GenerateRandom());
        Console.WriteLine("2.2");

        await Task.Delay(GenerateRandom());
        Console.WriteLine("2.3");
    }

    public static async Task print3()
    {
        await Task.Delay(GenerateRandom());
        Console.WriteLine("3.1");

        await Task.Delay(GenerateRandom());
        Console.WriteLine("3.2");

        await Task.Delay(GenerateRandom());
        Console.WriteLine("3.3");
    }


    static int GenerateRandom()
    {
        Random random = new Random();
        return random.Next(300, 1000);
    }

}