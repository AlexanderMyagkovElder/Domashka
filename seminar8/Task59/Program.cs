/*Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7*/
int m = Vvod("Введите число строк массива: ");
int n = Vvod("Введите число столбцов массива: ");
int[,] massive = new int[m, n];
int[,] newmassive=new int[m-1,n-1];
Zapolnenie(massive);
PrintArray(massive);
int min = massive[0, 0];
int stroka = 0;
int stolbec = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (massive[i, j] < min)
        {
            min = massive[i, j];
            stroka=i;
            stolbec=j;
        }
    }
}
Console.WriteLine();
Console.WriteLine($"Минимальный элемент равен {min}, находится в {stroka+1} строке, в {stolbec+1} столбце");
for (int k = 0; k < newmassive.GetLength(0); k++)
{
    for (int l = 0; l < newmassive.GetLength(1); l++)
        {
            if (k<stroka&&l<stolbec)
            {
                newmassive[k,l]=massive[k,l];
            }
            else if (k==stroka&&l<stolbec)
            {
                newmassive[k,l]=massive[k+1,l];
            }
            else if (k<stroka&&l==stolbec)
            {
                newmassive[k,l]=massive[k,l+1];
            }
            else
            {
                newmassive[k,l]=massive[k+1,l+1];
            }
        }
}
Console.WriteLine();
PrintArray(newmassive);
int Vvod(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],-5}");
        }
        Console.WriteLine();
    }
}
void Zapolnenie(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
