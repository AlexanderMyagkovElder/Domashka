//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max)
{
    if (c > b)
    {
        Console.WriteLine("Максимальное число: " + c);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + b);
    }
}
else
{
    if (c > max)
    {
        Console.WriteLine("Максимальное число: " + c);
    }
    else Console.WriteLine("Максимальное число: " + a);
}
