// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и
// последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int ReadNumber(string massageToUser)
{
    Console.WriteLine(massageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[] FillArray(int length, int leftnum = int.MinValue, int rightnum = int.MaxValue)
{
    int[] rand_arr = new int[length];
    for (int i = 0; i < rand_arr.Length; i++)
    {
        rand_arr[i] = Random.Shared.Next(leftnum, rightnum + 1);
    }
    return rand_arr;
}

int[] LengthArray(int[] array)
{
    if (array.Length % 2 == 0)
    {
        return new int[array.Length / 2];
    }
    else
    {
        return new int[array.Length / 2 + 1];
    }
}

int[] MultiplyArray(int[] array)
{
    int[] result = LengthArray(array);
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - i - 1];
    }
    if (array.Length % 2 != 0)
    {
        result[result.Length - 1] = array[array.Length / 2];
    }
    return result;
}

int lengthOfArray = ReadNumber("Задайте длину массива: ");
int leftBorder = ReadNumber("Задайте левую границу случайного диапазона: ");
int rightBorder = ReadNumber("Задайте правую границу случайного диапазона: ");

int[] filled_array = FillArray(lengthOfArray, leftBorder, rightBorder);
Console.WriteLine($"{string.Join(',', filled_array)} -> {string.Join(',', MultiplyArray(filled_array))}");

