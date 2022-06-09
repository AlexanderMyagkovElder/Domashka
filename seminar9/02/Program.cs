/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
int m = EnterNumbers("Введите значение числа M: ");
int n = EnterNumbers("Введите значение числа N: ");
int sum = Summa(m, n);
Console.WriteLine(sum);
int Summa(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber)
    {
        return firstNumber;
    }
    else
    {
        return firstNumber + Summa(firstNumber + 1, secondNumber);
    }
}
int EnterNumbers(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}