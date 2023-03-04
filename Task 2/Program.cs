/*
Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке 
от M до N. Рекурсия!

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int ShowNumbers(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    return ShowNumbers(m + 1, n) + m;

}
Console.WriteLine(ShowNumbers(1, 15));