// Найти сумму цифр числа

int n = 12315;



int SumNumbersRec (int n)
{
    if (n < 10) return n;
    else  return n % 10 + SumNumbersRec(n / 10);
}

Console.WriteLine(SumNumbersRec(n));