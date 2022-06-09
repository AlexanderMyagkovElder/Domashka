/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9*/
int m = EnterNumbers("Введите значение числа M: ");
int n = EnterNumbers("Введите значение числа N: ");
if (m<0||n<0)
{
    Console.WriteLine("Введите корректное значение чисел");
}
else
{
    int result=Akkerman(m,n);
    Console.WriteLine(result);
}
int Akkerman(int first,int second)
{
    if (first==0)
    {
        return second+1;
    }
    else if (first>0&&second==0)
    {
        return Akkerman(first-1,1);
    }
    else
    {
        return Akkerman(first-1,Akkerman(first,second-1));
    }
}
int EnterNumbers(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
