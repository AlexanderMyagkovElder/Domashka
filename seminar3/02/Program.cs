/*Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними в 3D пространстве.*/
Console.Write("Введите координату Х точки А: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки А: ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Х точки B: ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
int c2 = Convert.ToInt32(Console.ReadLine());
int katet1 = a2-a1;
int katet2=b2-b1;
int katet3=c2-c1;
double distance = Math.Sqrt(katet1*katet1+katet2*katet2+katet3*katet3);
Console.WriteLine("Расстояние между двумя точками равно "+distance);