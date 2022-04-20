// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine("Число " + a + " кратное");
}
else
{
    Console.WriteLine("Число " + a + " некратное");
}