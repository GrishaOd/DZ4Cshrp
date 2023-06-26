/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

double GivePower(int x, int y)
{
    double result = Math.Pow(x, y);
    return result;
}

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());

double itog = GivePower(A, B);
Console.Write($"{A} в степени {B} равно {itog}");
