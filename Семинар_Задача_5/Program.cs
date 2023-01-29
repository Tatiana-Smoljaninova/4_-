// Напишите прогр, кот принимает на вход число и выдает кол-во цифр в числе
// 456 - 3
// 78 - 2
// 89126 - 5

int Lenght(int number) // ввожу функцию
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count = count + 1;
    }
    return count;
}

Console.Write("Введите число: ");    
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"{number} -> {Lenght(number)}");  