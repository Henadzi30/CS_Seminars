// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов
// массива, значения которых лежат в отрезке [10,99].

// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// Console.WriteLine("Hello, World!");

int ReadNumber(string massageToUser)
{
    Console.WriteLine(massageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[] GetRandomArray(int length, int leftBorder, int rightBorder)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftBorder, rightBorder + 1);
    }
    return array;
}

int GetQuantityNumbers(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            quantity += 1;
        }
    }
    return quantity;
}

int lengthOfArray = 123;
int leftBorder = 1;
int rightBorder = ReadNumber("Задайте правую границу случайного диапазона: ");

int[] StandartArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);
Console.WriteLine($"[{string.Join(", ", StandartArray)}]");

int numberQuantity = GetQuantityNumbers(StandartArray);
Console.WriteLine($"Количество чисел массива, находящихся в пределах от 10 до 99, составляет: {numberQuantity}");
