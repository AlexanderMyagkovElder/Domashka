/*Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */
Console.Write("Введите количество строк (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов (n): ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] massive = new int[m,n];
GetArray(massive);
Console.Write("Введите позицию элемента: ");
int position=Convert.ToInt32(Console.ReadLine());
if (position<10||position>99)
    Console.WriteLine("Введите двузначное число!");
int stroka=position/10;
int stolbec=position%10;
if (stroka>m||stolbec>n)
    {
        Console.Write("Такого числа в массиве нет");
    }
    
else Console.Write($"Числом на позиции {position} является {massive[stroka-1,stolbec-1]}");
void GetArray(int[,]array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            massive[i,j]=new Random().Next(-10,10);
            Console.Write(massive[i,j]+"   ");
        }
        Console.WriteLine();
    }
}

