// Написать программу возведения числа А в целую стень B

int PowerOfNumbers(int a, int b)
{
    if (b == 1) return a;
    else if (b == 0) return 1;
    else  return (a * PowerOfNumbers(a, b - 1));
}

Console.WriteLine(PowerOfNumbers(3,4));