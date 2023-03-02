// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3  -> 11
// 2  -> 10


// Задаем метод запроса информации от пользователя
int ReadNumber(string massageToUser)
{
    Console.WriteLine(massageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

// Блок запрашиваемoй у пользователя информации
int numberFromUser = ReadNumber("Введите десятичное число для преобразования в двоичное: ");

// Блок определения длины двоичного числа
int n = numberFromUser;
int countOfDigits = 0;
int nCopy = numberFromUser;

while (nCopy != 0)
{
    nCopy /= 2;
    countOfDigits++;
}
Console.WriteLine($"Длина массива десятичного числа {numberFromUser} в двоичном коде: {countOfDigits}");

// Метод перевода десятичного числа в перевернутое двоичное число

int[] binaryNumber = new int[countOfDigits];

for (int i = 0; i < binaryNumber.Length; i++)
{
    binaryNumber[i] = n % 2;
    n /= 2;
} 

// Задаем метод замены элементов массива (первые с последними) - преобразование в двочный код 
void ReversArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}


Console.WriteLine($"Рузультат деления десятичного числа на '2': {string.Join("", binaryNumber)}");
ReversArray(binaryNumber);
Console.WriteLine($"Результат преобразования десятичного числа {numberFromUser} в двоичное: {string.Join("", binaryNumber)}");

// Другой вариант
int n = 44;

void PrintBinary(int n)
{
    if (n == 0) return;
    PrintBinary(n / 2);
    Console.Write(n % 2);
}
PrintBinary(n);
