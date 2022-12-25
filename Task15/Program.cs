// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number >= 1) & (number <= 7))
{
    Console.WriteLine(IsWeekend(number));
}
else
{
    Console.WriteLine("Введена неверная цифра");
}

string IsWeekend(int num)
{
    string IsWeekend;
    if ((num == 6) | (num == 7))
    {
        IsWeekend = "да";
    }
    else
    {   
        IsWeekend = "нет";
    }
    return IsWeekend;
}
