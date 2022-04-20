// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int n = 1;
while (n <= N)
{
    if (n % 2 == 0)
    {
        Console.Write(n + ", ");
        n++;
    }
    else n++;
}