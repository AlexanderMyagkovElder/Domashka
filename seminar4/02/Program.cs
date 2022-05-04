/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11  82 -> 10   9012 -> 12*/
Console.Write("Введите число: ");
int chislo = Convert.ToInt32(Console.ReadLine());
string chisloMassive = Convert.ToString(chislo);
int sum = 0;
for (int i = 0; i < chisloMassive.Length; i++)
{
    sum = sum + Convert.ToInt32(chisloMassive[i].ToString());
}
Console.WriteLine(sum);
