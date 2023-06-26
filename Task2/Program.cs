/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int i = 0;
while (number > 0)
{
    int ostatok = number % 10;
    i += ostatok;
    number /= 10;
}

Console.WriteLine($"Сумма цифр в числе: {i}");