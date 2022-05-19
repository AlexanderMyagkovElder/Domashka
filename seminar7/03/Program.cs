/*Задача 52: Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.*/
Console.Write("Введите количество строк (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов (n): ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] massive = new int[m,n];
GetArray(massive);
double[] sum=new double[n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        sum[j]+=massive[i,j];
    }
}
Console.WriteLine();

for (int k = 0; k < sum.Length; k++)
    {
        double middleArithmetic=Math.Round(sum[k]/m,1);
        Console.Write(middleArithmetic+"   ");
    }
    Console.WriteLine();

void GetArray(int[,]array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            massive[i,j]=new Random().Next(0,10);
            Console.Write(massive[i,j]+"   ");
        }
        Console.WriteLine();
    }
}

