/*Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом.*/
Console.Write("Введите пятизначное число: ");
int chislo = Convert.ToInt32(Console.ReadLine());
string massive = Convert.ToString(chislo);
if (massive.Length<5||massive.Length>5)
{
    Console.WriteLine($"{chislo} не пятизначное число!");
}
else
{
   Reshenie(massive);
}

void Reshenie (string massive)
{
    if (massive[0]==massive[4]||massive[1]==massive[3])
    {
        Console.WriteLine(chislo+" является палиндромом");
    }
    else
    {
        Console.WriteLine(chislo+" не является палиндромом");
    }
}