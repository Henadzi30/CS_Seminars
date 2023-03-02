// Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования.

int[] GetRandomArray(int length, int leftBorder, int rightBorder)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftBorder, rightBorder + 1);
    }
    return array;
}

const int LENGTH = 6;
const int LEFTBORDER = -10;
const int RIGHTBORDER = 10;

int[] myArray = GetRandomArray(LENGTH, LEFTBORDER, RIGHTBORDER);
// int[] myArrayClone = myArray;

int[] myArrayClone = new int[myArray.Length];

for (int i = 0; i < myArray.Length; i++)
{
    myArrayClone[i] = myArray[i];
}

myArray[2] = 177;
Console.WriteLine(string.Join(", ", myArray));
Console.WriteLine(string.Join(", ", myArrayClone));

