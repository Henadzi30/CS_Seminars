// Задайте двумерный массив. Найдите сумму элементов, находящихся
// на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12

// Блок формирования переменных на основании введенных пользователем данных
int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
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

// Метод получения суммы чисел по главной диагонали 
int GetSumDiagonal(int[,] maTrix)
{
    int sumElement = 0;
    for (int i = 0; i < maTrix.GetLength(0); i++)
    {
        for (int j = 0; j < maTrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sumElement += maTrix[i, j];
            }
        }
    }
    return sumElement;
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
int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
int Left = ReadNumber("Введите нижнее значение случайных чисел: ");
int Right = ReadNumber("Введите верхнее значение случайных чисел: ");

// Блок вывода результатов в консоль
int[,] myMatrix = GetRandomMatrix(m, n, Left, Right);
PrintMatrix(myMatrix);
Console.WriteLine($"Сумма элементов главной диагонали: {GetSumDiagonal(myMatrix)}");
