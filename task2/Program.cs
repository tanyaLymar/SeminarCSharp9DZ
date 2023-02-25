// Показать натуральные числа от N до 1, N задано

int n = 5;
int a = 1;

string NumbersRec (int n, int a)
{
    if (n >= a) return $"{n} " + NumbersRec(n-1,a) ;
    else return String.Empty;
}

Console.WriteLine(NumbersRec(n, a));