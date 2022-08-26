Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

void ExampleThree()
{
    if (num == 6 || num == 7)
    {
        Console.WriteLine("Да");
    }
    else if (num < 1 || num > 7)
    {
        Console.WriteLine("Номер не соответствует продолжительности недели");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
ExampleThree();