// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Задаем метод запроса информации от пользователя
int ReadNumber(string massageToUser)
{
    Console.Write(massageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

// Метод вывода чисел от 1 до N
void ReturnIntegers(int N)
{
    if (N < 1) return;
    ReturnIntegers(N - 1);
    Console.Write($"{N}, ");        
}

int num = ReadNumber("Введите число N, для которого необходимо вывести все натуральные числа от 1 до N: ");
ReturnIntegers(num);