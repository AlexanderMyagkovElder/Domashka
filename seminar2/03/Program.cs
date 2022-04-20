//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
int[] week = { 1, 2, 3, 4, 5, 6, 7 };
Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day <= 0 || day > 7) 
{
    Console.WriteLine("В неделе 7 дней! Будьте внимательны...");
}
else
{
    if (week[day - 1] < 6)
    {
    Console.WriteLine("нет, это не выходной");
    }
    else
    {
    Console.WriteLine("да, это выходной");
    }
} 


