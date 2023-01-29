// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит
//число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

double Power (int A, int B) // если скобки пустые - метод не принимает параметров
                           // если скобки не пустые - метод принимает на вход указан
                          //параметры
{
    double result = Math.Pow(A, B);
    return result;
}

Console.Write("Введите значение А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write($"Число {A} в степени {B} равно {Power(A, B)}");