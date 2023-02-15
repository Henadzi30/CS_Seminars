//Напишите программу, 

int number = Random.Shared.Next(10, 100);
Console.WriteLine(number);
int lastDigit = number % 10;
int firstDigit = number / 10;
if (firstDigit > lastDigit)
{
    // Console.WriteLine("max");
    // Console.WriteLine(firstDigit);
    // Console.WriteLine("min");
    // Console.WriteLine(lastDigit);       
    Console.WriteLine($"max {firstDigit}, min {lastDigit}");
}
else
{
    // Console.WriteLine("max");
    // Console.WriteLine(lastDigit);
    // Console.WriteLine("min");
    // Console.WriteLine(firstDigit);
    // Console.WriteLine("max " + firstDigit + " min " + lastDigit);           
    Console.WriteLine($"max {lastDigit}, min {firstDigit}");
}
