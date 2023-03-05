// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
//  Aₘₙ = m + n. Выведите полученный массив на экран.

// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


// Метод создания переменных по запрашиваемым у пользователя данным 
int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

// Метод создания массива чисел по заданным пользователем данным
int[,] GetRandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
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

// Блок запрашиваемой у пользователя информации
int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");

// Блок вывода результата в консоль
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
