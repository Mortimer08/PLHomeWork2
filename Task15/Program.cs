// Задача 15: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// Пример:
// 6 -> да
// 7 -> да
// 1 -> нет

bool IsWeekDayNumber(int num)
{
    if (num > 0 && num < 8) return true;
    return false;
}

bool IsWeekEnd(int num)
{
    if (num == 6 || num == 7) return true;
    return false;
}

System.Console.WriteLine("Введите цифру для дня недели");
int number = Convert.ToInt32(Console.ReadLine());

if (IsWeekDayNumber(number) && IsWeekEnd(number))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}