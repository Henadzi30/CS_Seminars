// Напишите программу, которая принимает на вход число N и выдаёт
// произведение чисел от 1 до N.

// 4 -> 24 
// 5 -> 120

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int productOfNumber(int n)
{
    int product = 1;
    for (int i = 1; i <= n; i++)
    {
        product *= i;
    }
    return product;
}

int number = ReadNumber("Введите число N");
int result = productOfNumber(number);
Console.WriteLine(result);
