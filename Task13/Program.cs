// Задача 13: Напишите программу,
// которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// Пример
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

bool IsThreeDigits(int numToCheck)
{
    if (numToCheck > 100 && numToCheck < 999) return true;
    return false;
}

bool IsMoreThreeDigits(int num)
{
    if (num > 100) return true;
    return false;
}

System.Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());


if (IsMoreThreeDigits(number))          // Замечание преподавателя - метод - избыточность
{
    int currentNumber = number;
    while (!IsThreeDigits(currentNumber))
    {
        currentNumber = currentNumber / 10;
    }
    int thirdDigit = currentNumber % 10;
    System.Console.WriteLine(thirdDigit);
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}