// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Введите число: ");
int chislo = Convert.ToInt32(Console.ReadLine());
if (chislo<100)
{
    Console.WriteLine("Число не содержит третью цифру. Попробуй другое.");
} 
else
{
    string massive = Convert.ToString(chislo);
    Console.WriteLine(massive[2]);
}
