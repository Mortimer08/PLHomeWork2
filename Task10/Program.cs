// Задача 10: Напишите программу, которая 
// принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// Например:
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit(int num)
{
    return num / 10 % 10;
}

System.Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 100 && number < 999)
{
    Console.WriteLine(SecondDigit(number));
}
else Console.WriteLine("Вы ввели не трёхзначное число");