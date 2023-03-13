// Задайте двумерный массив. Напишите программу, которая поменяет местами
// первую и последнюю строку массива.

//  Метод создания переменных по запрашиваемым у пользователя данным
int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

// Метод создания массива элементами из рандомных чисел
int[,] GetRandomMatrix(int rows, int columns, int leftBorder, int rightBorder)
{
    int[,] matrix = new int[rows, columns]; // Резервируем место в памяти машины

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1); // Заполняем рандомными числами элементы массива
        }
    }
    return matrix;
}

// Метод создания массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Метод изменения массива (замена местами первой и последней строк)
void PrintModifiedMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }
}

// Блок запроса информации от пользователя 
int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
int Left = ReadNumber("Введите нижнее значение случайных чисел: ");
int Right = ReadNumber("Введите верхнее значение случайных чисел: ");

// Блок вывода результата в консоль 
int[,] myMatrix = GetRandomMatrix(m, n, Left, Right);
Console.WriteLine();
PrintMatrix(myMatrix);
PrintModifiedMatrix(myMatrix);
Console.WriteLine();
PrintMatrix(myMatrix);
