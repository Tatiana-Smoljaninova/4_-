// Задача 28. Напишите прогр, кот принимает на вход число N и выдает произведение чисел
//от 1 до N.
// 4 - 24
// 5 - 120 // применить метод

int Sum(int N) // задали метод
{
    int sum = 1;  //итоговая сумма
    for (int i = 1; i <= N; i++)
    {
        sum = sum * i;
    }
    return sum;
}    

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"{N} -> {Sum(N)}");