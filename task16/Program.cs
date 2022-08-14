// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int Quadro (int a)
{
    return a * a;
}

int quadro1 = Quadro(number1);
int quadro2 = Quadro(number2);

if (quadro1 == number2)
{
Console.WriteLine("Число " + number2 + " является квадратом числа " + number1);
}

else if (quadro2 == number1)
{
Console.WriteLine("Число " + number1 + " является квадратом числа " + number2);
}

else
{
   Console.WriteLine("Числа не являются квадратом друг друга"); 
}
