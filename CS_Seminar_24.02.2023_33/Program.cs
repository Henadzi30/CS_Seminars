// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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

bool numberSurch(int[] array, int numberForSurch)
{
    bool result = false; 
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == numberForSurch)
        {
             result = true;
             break;
        }
    }
    return result;
}

string FlagAnswer(bool result)
{
    string answ = "";
    if (result == true)
    {
        answ = "да";
    }
    if (result == false)
    {
        answ = "нет";
    }
    return answ;    
}
    
int lengthOfArray = ReadNumber("Задайте длину массива: ");
int leftBorder = ReadNumber("Задайте левую границу случайного диапазона: ");
int rightBorder = ReadNumber("Задайте правую границу случайного диапазона: ");
int numberForSurch = ReadNumber("Задайте число, которое следует искать в массиве: ");

int[] StandartArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);
Console.WriteLine($"[{string.Join(", ", StandartArray)}]");

bool res = numberSurch(StandartArray, numberForSurch);
string include = FlagAnswer(res);
Console.WriteLine(include);



