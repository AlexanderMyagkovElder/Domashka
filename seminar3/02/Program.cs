/*Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними в 3D пространстве.
(3,6,8) (2,1,-7)  => 15.84
(7,-5,0) (1,-1,9) => 11.53*/
int x1 = Vvod("X", "A");
int y1 = Vvod("Y", "A");
int z1 = Vvod("Z", "A");
int x2 = Vvod("X", "B");
int y2 = Vvod("Y", "B");
int z2 = Vvod("Z", "B");
double Katet(int a, int b)
{
    int katet = a - b;
    return Math.Pow(katet, 2);
}
double katet1 = Katet(x2, x1);
double katet2 = Katet(y2, y1);
double katet3 = Katet(z2, z1);
double distance = Math.Sqrt(katet1 + katet2 + katet3);
Console.WriteLine("Расстояние между двумя точками равно " + distance);

int Vvod(string XYZ, string AB)
{
    Console.Write($"Введите координату {XYZ} точки {AB}: ");
    return Convert.ToInt32(Console.ReadLine());
}