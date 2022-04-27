/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.*/
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int stepen = 1;
Console.WriteLine($"{a} в {b} степени равняется {Stepen(a,b)}");


int Stepen(int x,int y)
{
    for (int i = 1; i <= y; i++)
    {
        stepen = stepen * x;
    }
    return stepen;
}