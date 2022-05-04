/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11  82 -> 10   9012 -> 12*/
Console.Write("Введите число: ");
int chislo = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (chislo>0)
{
    sum=sum+chislo%10;
    chislo=chislo/10;    
}
Console.WriteLine(sum);