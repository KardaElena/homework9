// Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1.

// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2"

int[] ArrayN(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
    }

    return array;
}

void PrintEven(int[] array)
{
    for (int i = array.Length - 1; i > 0; i--)
    {
        if (array[i] % 2 == 0) Console.Write($"{array[i]} ");
    }
}


Console.Clear();

Console.Write("Введите число больше единицы: ");
int n = int.Parse(Console.ReadLine() ?? "");

while (n == 1 || n < 1)
{
    Console.WriteLine("Ошибка. Число равно 1 или меньше. Введите число больше 1: ");
    n = int.Parse(Console.ReadLine() ?? "");
}

int[] array = ArrayN(n);
Console.WriteLine();
PrintEven(array);
Console.WriteLine();

