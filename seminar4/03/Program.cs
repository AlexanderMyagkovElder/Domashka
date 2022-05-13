/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33] */

Console.WriteLine("Введите ряд чисел через запятую: ");
string? vvodimoe = Console.ReadLine();
string vyvod = string.Empty;
for (int i = 0; i < vvodimoe.Length; i++)
{
    if (vvodimoe[i]==',') 
    {
        vyvod=vyvod+", ";
    }
    else vyvod=vyvod+vvodimoe[i];
}
Console.Write("{");
for (int i = 0; i < vyvod.Length; i++)
{
    Console.Write(vyvod[i]);
}
Console.Write("}");