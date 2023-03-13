// Задача 65: Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.

// M = 1; N = 5-> "1, 2, 3, 4, 5"
// M = 4; N = 8-> "4, 5, 6, 7, 8"

// Задаем метод запроса информации от пользователя
int ReadNumber(string massageToUser)
{
    Console.Write(massageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

// Метод вывода чисел от 1 до N
void ReturnIntegers(int M, int N)
{
    if (M > N) return;
    ReturnIntegers(M, N - 1);
    Console.Write($"{N}, ");
}

int numM = ReadNumber("Введите число M: ");
int numN = ReadNumber("Введите число N: ");
ReturnIntegers(numM, numN);