// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SummMN(int m, int n)
{
    if (m == n) return n;
    else return n + SummMN(m, n - 1);
}


Console.Clear();

Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"Сумма элементов между {m} и {n} включительно равна {SummMN(m, n)}");



