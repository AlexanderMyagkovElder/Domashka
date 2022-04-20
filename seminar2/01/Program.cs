//Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int chislo = Convert.ToInt32(Console.ReadLine());
string massive = Convert.ToString(chislo);
Console.WriteLine(massive[1]);

