// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Задаем метод запроса информации от пользователя
int ReadNumber(string massageToUser)
{
    Console.WriteLine(massageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

// Задаем метод создания произвольного массива по даным от пользователя
int[] GetRandomArray(int length, int leftBorder, int rightBorder)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftBorder, rightBorder + 1);
    }
    return array;
}

// Задаем метод замены элементов массива (первые с последними)
void ReversArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}

// const int LENGTH = 12; const - задает переменную константой, ее уже потом в коде 
// нельзя поменять, а для узнаваемости константные переменные пишутся БОЛЬШИМИ БУКВАМИ 
// const int LEFTBORDER = -10;
// const int RIGHTBORDER = 10;

// Блок запрашиваемщй у пользователя информации
int lengthOfArray = ReadNumber("Задайте длину массива: ");
int leftBorder = ReadNumber("Задайте левую границу случайного диапазона: ");
int rightBorder = ReadNumber("Задайте правую границу случайного диапазона: ");

// Создание произвольного массива по данным пользователя
int[] StandartArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);
// Вывод массива в терминал 
Console.WriteLine($"[{string.Join(", ", StandartArray)}]");
// Переворачиваем массив
ReversArray(StandartArray);
// Выводим в терминал перевернутый масив
Console.WriteLine($"[{string.Join(", ", StandartArray)}]");