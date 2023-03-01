// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int ReadNumber(string massageToUser)
{
    Console.WriteLine(massageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}



int[] Fibonachi(int n)
{
    int[] array = new int[n];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 2] + array[i - 1];
    }
    return array;
}
 
int fib4 = ReadNumber("Введите число для расчета чисел Фибоначчи: ");
int[] fib5 = Fibonachi(fib4);
 
Console.WriteLine($"Последовательность чисел Фибоначчи от заданного {fib4 } представляется: {string.Join(", ", fib5)}");
