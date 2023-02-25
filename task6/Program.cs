// Написать программу вычисления функции Аккермана

int FunctionAccerman(int m, int n) 

{
        if (m == 0) return n + 1; 
        else if (n == 0 && m > 0)
        {
            return FunctionAccerman(m - 1, 1);
        } 
        else 
        {
            return FunctionAccerman(m - 1, FunctionAccerman(m, n - 1));
        }
    }

Console.WriteLine(FunctionAccerman(3, 2));