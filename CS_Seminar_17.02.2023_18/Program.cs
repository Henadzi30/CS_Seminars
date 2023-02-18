// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

// 1 -> “x > 0 && y > 0” 
// 2 -> “x < 0 && y > 0” 
// 3 -> “x < 0 && y < 0” 
// 4 -> “x > 0 && y < 0”
// 5 -> “Неверно введен номер четверти” 


Console.WriteLine("Введите номер четверти, чтобы узнать диапазон координат: ");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter == 1)
{
    Console.WriteLine("x > 0 && y > 0");
}
else if (quarter == 2)
{
    Console.WriteLine("x < 0 && y > 0");
}
else if (quarter == 3)
{
    Console.WriteLine("x < 0 && y < 0");
}
else if (quarter == 4)
{
    Console.WriteLine("x > 0 && y < 0");
}
else
{
    Console.WriteLine("Неверно введен номер четверти");
}