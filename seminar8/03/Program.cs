/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/
int sideArray = EnterNumbers("Введите длинну стороны массива: ");
int[,] squareArray = new int[sideArray, sideArray];
int[] answerArray = new int[sideArray];
FillArrayRandom(squareArray);
PrintArray(squareArray);
Console.WriteLine();
for (int i = 0; i < sideArray; i++)
{
    for (int j = 0; j < sideArray; j++)
    {
        answerArray[i] += squareArray[i, j];
    }
}
int answerNumber = answerArray[0];
int answerString = 0;
for (int i = 1; i < sideArray; i++)
{
    if (answerArray[i] < answerNumber)
    {
        answerNumber = answerArray[i];
        answerString = i;
    }
}
Console.WriteLine($"Ответ: строка {answerString + 1} с суммой элементов {answerNumber}");
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


