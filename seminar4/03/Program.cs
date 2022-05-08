/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33] */

Console.WriteLine("Введите ряд чисел через запятую: ");
string vvodimoe = Convert.ToString(Console.ReadLine());
Console.Write("{");
for (int i = 0; i < vvodimoe.Length; i++)
{
    if (vvodimoe[i]==',') continue;
    else Console.Write(vvodimoe[i]+" ");
}
Console.Write("}");