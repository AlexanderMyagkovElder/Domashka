/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */
int dlinnaMassive = new Random().Next(1, 10);
int[] massive = new int[dlinnaMassive];
int sum = 0;
Zapolnenie(massive);
for (int i = 0; i < massive.Length; i++)
{
    if (massive[i] % 2 == 0)
    {
        sum++;
    }
    else continue;
}
Console.WriteLine($"Количество четных чисел в массиве равно {sum}");

void Zapolnenie(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
