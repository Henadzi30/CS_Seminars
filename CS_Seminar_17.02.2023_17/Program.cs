// Напишпите программу
Console.WriteLine("Введите координату точки по Х");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки по Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой координатной четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во второй координатной четверти");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей координатной четверти");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвертой координатной четверти");
}
else 
{
    Console.WriteLine("Невозможно определить координатную четверть!");
}