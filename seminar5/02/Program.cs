/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
int dlinnaMassive = new Random().Next(1, 10);
int[] massive = new int[dlinnaMassive];
int sum = 0;
Zapolnenie(massive);
for (int i = 0; i < massive.Length; i++)
{
    if (i % 2 == 1)
    {
        sum+=massive[i];
    }
    else continue;
}
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равно {sum}");

void Zapolnenie(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

