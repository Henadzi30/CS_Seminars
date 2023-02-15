// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8, 9  ->  нет

Console.WriteLine("Введите число а: ");
int digit_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int digit_b = Convert.ToInt32(Console.ReadLine());


if (digit_a * digit_a == digit_b | digit_b * digit_b == digit_a)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
