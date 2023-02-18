// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// AB = √(xb - xa)2 + (yb - ya)2

Console.WriteLine("Введите координаты первой точки 'А': ");
double xA = Convert.ToDouble(Console.ReadLine());
double yA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки 'B': ");
double xB = Convert.ToDouble(Console.ReadLine());
double yB = Convert.ToDouble(Console.ReadLine());

double distance = (Math.Sqrt(Math.Pow(xB - xA , 2) + Math.Pow(yB - yA, 2)));

Console.WriteLine(Math.Round(distance, 2));


