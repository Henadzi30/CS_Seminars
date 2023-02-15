// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите число а: ");
int digit_a = Convert.ToInt32(Console.ReadLine());

if (digit_a % 7 == 0 & digit_a % 23 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
