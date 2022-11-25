// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int[] ArrayN(int n)
{
    int[] array = new int[n];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
    }
    return array;
}

Console.Clear();

Console.Write("Введите число: ");

int n = int.Parse(Console.ReadLine() ?? "");
int[] array = ArrayN(n);

Console.Write(string.Join(' ', array));
Console.WriteLine();

