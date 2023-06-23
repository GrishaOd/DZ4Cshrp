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
}
int result = number + i;

Consol.eWriteLine(result);