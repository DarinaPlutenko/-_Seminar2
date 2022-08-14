// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = new Random().Next(1, 1000);
Console.WriteLine("Случайное число = " + number);
int digit1 = number % 100;
int digit2 = digit1 % 10;

if (digit2 > 0)
{
    Console.WriteLine($"Третья цифра = {digit2}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}