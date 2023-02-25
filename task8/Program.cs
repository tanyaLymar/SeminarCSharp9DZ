// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих
// Первые два элемента последовательности задаются пользователем.

String Fibonacci(int x1, int x2, int n) 
{
    if (n == 0)
        return String.Empty;
    else
    {   
        return $"{(x2 + x1)} " + Fibonacci(x2, x2+x1, n  - 1);
    }
}



Console.WriteLine("Введите первый элемент: ");
int a = int.Parse(Console.ReadLine() ?? "");;
Console.WriteLine("Введите второй элемент: ");
int b = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите длину последовательности: ");
int N = int.Parse(Console.ReadLine() ?? "");
int n = N -2;
Console.Write($"Последовательность: {a} {b} ");
Console.WriteLine(Fibonacci(a, b, n));