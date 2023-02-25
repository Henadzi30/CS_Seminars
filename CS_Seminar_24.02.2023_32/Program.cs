// Напишите программу замена элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// Создаем блок для считывания данных от пользователя

int ReadNumber(string massageToUser)
{
    Console.Write(massageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

// Создаем метод по формированию массива по данным пользователя 

int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }
    return array;
}

// Создаем метод по замене знака в массиве

int[] invertedArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

// Блок запроса требуемой информации

int lengthOfArray = ReadNumber("Задайте длину массива: ");
int leftBorder = ReadNumber("Задайте левую границу случайного диапазона: ");
int rightBorder = ReadNumber("Задайте правую границу случайного диапазона: ");

// Блок вывода информации в терминал

int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);
Console.WriteLine($"[{string.Join(", ", myArray)}]");

int[] myInvertArray = invertedArray(myArray);
Console.WriteLine($"[{string.Join(", ", myInvertArray)}]");
