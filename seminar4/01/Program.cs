/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.*/
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int index = 1;
int stepen=1;
while (index<=b)
{
    stepen=stepen*a;
    index++;
}
Console.WriteLine(stepen);
