/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int GiveSum (int number)
{
int i = 0;
while (number > 0)
{
    int ostatok = number % 10;
    i += ostatok;
    number /= 10;
}
Console.WriteLine($"Сумма цифр в числе: {i}");
return i;
}
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int result = GiveSum(num);
Console.WriteLine(result);






