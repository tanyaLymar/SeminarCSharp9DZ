// Показать натуральные числа от 1 до N, N задано

int n = 5;
int a = 1;

string NumbersRec (int a, int n)
{
    if (n >= a) return $"{a} " + NumbersRec(a+1,n) ;
    else return String.Empty;
}

Console.WriteLine(NumbersRec(a,n));