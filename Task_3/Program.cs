//Факториал числа
Console.Clear();

int FactorialNumber(int n)
{
    int result = 1;

    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}

int FactorialNumberRec(int n)
{
    if(n == 1)
    {
        return 1;
    }
    else
    {
        return n * FactorialNumberRec(n - 1);
    }
}

Console.WriteLine(FactorialNumber(10));
Console.WriteLine(FactorialNumberRec(10));