/*
Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа 
в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/

void ShowNumbers(int m, int n)
{
    if (m > n)
    {
        return;
    }
    if (m % 2 == 0)
    {
        Console.Write($"{m} ");
        ShowNumbers(m + 1, n);
    }
    else ShowNumbers(m + 1, n);

}
ShowNumbers(1, 8);

