/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */
int dlinnaMassive = new Random().Next(2, 10);
double[] massive = new double[dlinnaMassive];
Zapolnenie(massive);
double diff = 0;
double min = 0;
double max = 0;
/*проверяю, если рандом выдаст только положительные числа больше 0*/
if (massive[0]<massive[1])
{
    min=massive[0];
    max=massive[1];
}
else
{
    min=massive[1];
    max=massive[0];
}
for (int i = 2; i < massive.Length; i++)
{
    if (massive[i]<min)
    {
        min=massive[i];
    }
    if (massive[i]>max)
    {
        max=massive[i];
    }
    else continue;
}
Console.WriteLine($"min = {min}");
Console.WriteLine($"max = {max}");
diff=max-min;
Console.WriteLine($"Разница элементов равна {diff}");

void Zapolnenie(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        /*array[i] = (new Random().NextDouble())*10;
        это я пробывал вещественный рандом*/
        array[i] = new Random().Next(-100,100);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
