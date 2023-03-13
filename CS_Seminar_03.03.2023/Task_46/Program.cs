// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.

// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Метод создания переменных по запрашиваемым у пользователя данным 
int ReadNumber(string massageToUser)
{
    Console.WriteLine(massageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

// Метод создания массива из случайных чисел
int[,] GetRandomMatrix(int rows, int columns, int leftBorder, int rightBorder)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1);
        }
    }
    return matrix;
}

// Метод создания матрицы из массива случайных чисел
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

// Блок запрашиваемой у пользователя информации
int m = ReadNumber("Введите количество строк: ");
int n = ReadNumber("Введите количество столбцов: ");
int left = ReadNumber("Введите нижний предел случайных чисел: ");
int right = ReadNumber("Введите верхний предел случайных чисел: ");

// Блок вывода результатов в консоль
int[,] myMatrix = GetRandomMatrix(m, n, left, right);
PrintMatrix(myMatrix);
