// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


int Composition(int a, int b)
{
    if (b == 1) return a;
    else return a * Composition(a, b - 1);
}

Console.Clear();

Console.WriteLine("Введите число а: ");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Число {a} в степени {b} равно {Composition(a, b)}");






