Console.Write("Введите трехзначное число ");
int x = Convert.ToInt32(Console.ReadLine());

void Example()
{
   int x1 = (x / 10) % 10;
   Console.WriteLine($"{x1}"); 
}
Example();