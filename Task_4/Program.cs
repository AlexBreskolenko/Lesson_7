//Вычеслить A(n)
Console.Clear();

int PowerNumber(int a,int n)
{
    int result = 1;

    for (int i = 1; i <= n; i++)
    {
        result *= a;
    }
    return result;
}

int PowerNumberRec(int a, int n) => n == 0 ? 1 : PowerNumberRec(a, n - 1) * a;

Console.WriteLine(PowerNumber(2, 10));
Console.WriteLine(PowerNumberRec(2, 10));
