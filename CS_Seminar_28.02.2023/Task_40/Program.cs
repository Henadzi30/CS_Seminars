// Напишите программу, которая принимает на вход три числа и проверяет, может ли
// существовать треугольник с сторонами такой длины.

// Задаем метод запроса информации от пользователя
int ReadNumber(string massageToUser)
{
    Console.WriteLine(massageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

// Задаем метод определения возможности существования треугольника АВС по 
// известным длинам его сторон
bool TrianglePossible(int side_A, int side_B, int side_C)
{
    bool flag_a = true;
    bool flag_b = true;
    bool flag_c = true;
    bool flag = true;
    
    if(side_A < side_B + side_C)
    {
        flag_a = true;
    }
    else flag_a = false;
    if(side_B < side_A + side_C)
    {
        flag_b = true;
    }
    else flag_b = false;
    if(side_C < side_A + side_B)
    {
        flag_c = true;
    }
    else flag_c = false;
    if (flag_a == flag_b && flag_a == flag_c)
    {
        flag = true;
    }
    else flag = false;
    return flag;
}

string Result(bool unswer)
{
    string answerString = "";
    if (unswer)
    {
        answerString = $"Треугольник с указанными сторонами существует.";
    }
    else answerString = $"Треугольник с указанными сторонами не существует.";
    return answerString;
}

// Блок запрашиваемoй у пользователя информации
int lengthOfASide = ReadNumber("Задайте длину стороны А треугольника АВС в см: ");
int lengthOfBSide = ReadNumber("Задайте длину стороны B треугольника АВС в см: ");
int lengthOfCSide = ReadNumber("Задайте длину стороны C треугольника АВС в см: ");

// Определение возможности существования треугольника АВС с заданными сторонами
bool TrianglePossibleUnswer = TrianglePossible(lengthOfASide, lengthOfBSide, lengthOfCSide);
// Вывод результата проверки 
string Unswer = Result(TrianglePossibleUnswer);
Console.WriteLine(Unswer);
