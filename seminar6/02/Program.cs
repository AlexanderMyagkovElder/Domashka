/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
double b1 = EnterNumbers("b1");
double k1 = EnterNumbers("k1");
double b2 = EnterNumbers("b2");
double k2 = EnterNumbers("k2");
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x+b1;
Console.WriteLine($"Точка пересечения прямых имеет координаты ({x}; {y})");
double EnterNumbers (string nameNumber)
{
    Console.Write($"Введите значение переменной {nameNumber}: ");
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}