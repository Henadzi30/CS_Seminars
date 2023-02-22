// Задача 26: Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int countDigitN(int n)
{
    int count = 0;
    while (n != 0)
    {
        n /= 10;
        count += 1;
    }
    return count;
}

int number = ReadNumber("Введите число: ");
int result = countDigitN(number);
Console.WriteLine(result);
