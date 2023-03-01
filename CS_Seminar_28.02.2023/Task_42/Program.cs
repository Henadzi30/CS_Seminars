// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3  -> 11
// 2  -> 10

int n = 44;
int countOfDigits = 0;
int nCopy = n;

while (nCopy != 0)
{
    nCopy /= 2;
    countOfDigits++;
}
Console.WriteLine(countOfDigits);

int[] binaryNumber = new int[countOfDigits];

for (int i = 0; i < binaryNumber.Length; i++)
{
    binaryNumber[i] = n % 2;
    n /= 2;
} 

Console.WriteLine(string.Join("", binaryNumber));
ReverseArray(binaryNumber);
Console.WriteLine(string.Join("", binaryNumber));

void ReversArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] 
    }
}
