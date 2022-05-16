/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.*/
Console.Write("Введите количество чисел (М): ");
int length=Convert.ToInt32(Console.ReadLine());
int[] massive=new int[length];
for (int i = 0; i < massive.Length; i++)
{
    Console.Write($"Введите {i+1} число: ");
    massive[i]=Convert.ToInt32(Console.ReadLine());
}
int sum=0;
for (int i = 0; i < massive.Length; i++)
{
    if (massive[i]>0)
    {
        sum++;
    }
}
Console.WriteLine(sum);