/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/
Console.Write("Введите число N: ");
double N = Convert.ToDouble(Console.ReadLine());
if (N<0) N=-N;
int index = 1;
while (index<=N)
{
    double cube=Cube(index,3);
    index++;
    Console.Write(cube+"  ");
}
double Cube(int a, int b)
{
    double cube=Math.Pow(a,3);
    return cube;
}