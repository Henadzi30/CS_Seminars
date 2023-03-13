// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5-> 243(3⁵)
// A = 2; B = 3-> 8

// Задаем метод запроса информации от пользователя
int ReadNumber(string massageToUser)
{
    Console.Write(massageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

// Метод вывода чисел от 1 до N
int ReturnIntegers(int A, int B)
{
    int power = 1;
    if (B == 0) return 1;
    power = A * ReturnIntegers(A, B - 1);
    return power;
}

int numA = ReadNumber("Введите число A: ");
int numB = ReadNumber("Введите число B: ");
Console.WriteLine(ReturnIntegers(numA, numB));

// Другой вариант исполнения рекурсии начиная со строки 18
// if (B == 0) return 1;
// return = A * ReturnIntegers(A, B - 1);
