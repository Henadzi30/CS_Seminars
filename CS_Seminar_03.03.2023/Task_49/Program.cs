// Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные,
// и замените эти элементы на их квадраты. Например, изначально массив
// выглядел вот так:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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

// Метод изменения массива (возведение в квадрат элементов массива с обоими нечетными индексами)
void PrintModifiedMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if ((i + 1) % 2 == 0 && (j + 1) % 2 == 0) 
            {
                matrix[i, j] *= matrix[i, j];
                Console.Write(matrix[i, j] + " ");
            }
            else Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Блок запроса информации от пользователя 
int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
int Left = ReadNumber("Введите нижнее значение случайных чисел: ");
int Right = ReadNumber("Введите верхнее значение случайных чисел: ");

// Блок вывода результата в консоль 
int[,] myMatrix = GetRandomMatrix(m, n, Left, Right);
PrintMatrix(myMatrix);
Console.WriteLine();
PrintModifiedMatrix(myMatrix);
