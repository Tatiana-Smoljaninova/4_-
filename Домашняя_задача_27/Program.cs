// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр
// в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int Sum(int A)
{
    int result = A % 10;             
    while (A / 10 > 0)              
    {
        A = A / 10;
        result = result + A % 10;  
    }
    return result;
}
    Console.Write("Напишите сумму: ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Сумма цифр числа {A} равна {Sum(A)}");