// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int mod1 = number % 7;
int mod2 = number % 23;

if (mod1 == 0 & mod2 == 0)
{
    Console.Write("кратно");
}
else
    Console.Write($"не кратно, остаток от 7 = {mod1}, остаток от 23 = {mod2}");