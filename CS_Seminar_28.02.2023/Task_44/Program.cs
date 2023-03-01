// See https://aka.ms/new-console-template for more information

int ReadNumber(string massageToUser)
{
    Console.WriteLine(massageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int Fibonachi(int n)
{
    if (n == 0 || n == 1) return n;
     
    return Fibonachi(n - 1) + Fibonachi(n - 2);
}
 
int fib4 = ReadNumber("Введите число для расчета чисел Фибоначчи: ");
int fib5 = Fibonachi(fib4);
 
Console.WriteLine(string.Join(", ", fib5));
