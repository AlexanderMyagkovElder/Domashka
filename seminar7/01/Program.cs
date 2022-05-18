/*Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
Console.Write("Введите количество строк (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов (n): ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] massive = new double[m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        //ввожу переменную, чтобы случайно увеличивать вещественный рандом
        int unknownVariable=new Random().Next(-10,10); 
        massive[i,j]=(Math.Round(new Random().NextDouble(),1))*unknownVariable;
    }
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(massive[i,j]+"   ");
    }
    Console.WriteLine();
}
