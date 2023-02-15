// Напишите программу, которая будет принимать на вход два числа и выводить,
//  является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.

Console.WriteLine("Введите число а: ");
int digit_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int digit_b = Convert.ToInt32(Console.ReadLine());

int result = digit_a % digit_b;
if (result != 0)
{
    Console.WriteLine($"Не кратно, остаток от деления: {result}");
}
else
{
    Console.WriteLine($"Число {digit_a} кратно числу {digit_b}");
} 


