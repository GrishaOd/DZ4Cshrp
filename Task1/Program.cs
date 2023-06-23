/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

double GivePower(int A, int B)
{
    double result = Math.Pow(A, B);
    return result;
}

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());

double itog = GivePower(A, B);
Console.Write($"число A в степени B равно {itog}");
