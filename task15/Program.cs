// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("введите цифру дня недели");
int x = Convert.ToInt32(Console.ReadLine());

if (x > 0 && x < 6)
{
    Console.Write("Будний день :(");
}

if (x > 5 && x < 8)
{
    Console.Write("Выходной!");
}

if (x < 1 || x > 7)
{
    Console.Write("Такого дня недели не существует");
}
