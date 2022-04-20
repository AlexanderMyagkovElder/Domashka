//Напишите программу, которая на вход принимает 2 числа и выдает, какое число большее, а какое меньшее
Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max) Console.WriteLine("Большее число: " + b + "  Меньшее число: " + a);
else Console.Write("Большее число: " + a + "  Меньшее число: " + b);