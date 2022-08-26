Console.Write("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());

void ExampleTwo()
{
        int x3 = (int)Math.Log10(x)-2;
    if (x < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else if (x > 100)
    {
        x = (x % (int)Math.Pow(10, x3 + 1) / (int)Math.Pow(10, x3));
        Console.WriteLine($"Третья цифра -> {x}");
    }
}
ExampleTwo();