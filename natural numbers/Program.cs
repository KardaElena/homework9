

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int[] ArrayNM(int n, int m)
{
    int[] array = new int[n - m + 1];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = m;
        m++;
    }
    return array;
}


Console.Clear();

Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine() ?? "");

Console.Write("\nВведите число m: ");
int m = int.Parse(Console.ReadLine() ?? "");

int[] array = ArrayNM(n, m);

Console.Write(string.Join(' ', array));
Console.WriteLine();

