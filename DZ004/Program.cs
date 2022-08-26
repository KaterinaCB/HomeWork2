Console.Write("Введите количество: ");
int x = Convert.ToInt32(Console.ReadLine());

void ExampleFour()
{
    if (x % 10 == 1 & x % 100 != 11)
    {
        Console.WriteLine($"{x} программист");
    }
    else if (x % 10 == 2 & x % 100 != 12 || x % 10 == 3 & x % 100 != 13 || x % 10 == 4 & x % 100 != 14)
    {
        Console.WriteLine($"{x} программиста");
    }
    else 
    {
        Console.WriteLine($"{x} программистов");
    }
}
ExampleFour();