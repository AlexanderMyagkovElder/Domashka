/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/
int m = EnterNumbers("Введите число строк массива: ");
int n = EnterNumbers("Введите число столбцов массива: ");
int[,] startArray = new int[m, n];
int[] answerArray = new int[m];
int temp=0;
FillArrayRandom(startArray);
PrintArray(startArray);
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        temp+=startArray[i,j];
    }
    answerArray[i]=temp;
    temp=0;
}
int findString=NeedString(answerArray);

for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Сумма {i+1} строки = {answerArray[i]}");
    }
        Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов: {findString+1}");
int NeedString(int[] array)
{
    temp=0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]<array[i-1])
        {
            temp=i;
        }
    }
    return temp;
}
int EnterNumbers(string text)
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
void FillArrayRandom(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

