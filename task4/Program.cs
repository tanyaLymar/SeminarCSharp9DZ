// Найти сумму элементов от M до N, N и M заданы

int m = 5;
int n = 0;



int SumNumbersRec (int m, int n)
{
    if (m > n) return m + SumNumbersRec(m-1, n) ;
    else return n;
}

Console.WriteLine(SumNumbersRec(m, n));


