/*Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом.*/
 Console.Write("Введите пятизначное число: ");
 int chislo = Convert.ToInt32(Console.ReadLine());
 string massive = Convert.ToString(chislo);
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
Reshenie(massive);
