// Задача 67: Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр.

// 453-> 12
// 45-> 9
// Задаем метод запроса информации от пользователя
int ReadNumber(string massageToUser)
{
    Console.Write(massageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

// Метод вывода чисел от 1 до N
int SumDigits(int N)
{
    if (N == 0) return 0;
    return N % 10 + SumDigits(N / 10);
}

int numN = ReadNumber("Введите число N: ");
Console.WriteLine(SumDigits(numN));