/*
Сумма чисел от 1 до N
*/
Console.Clear();


int SumNumbers(int n)
{
    int result = 0;

    for (int i = 0; i <= n; i++)
    {
        result += i;
    }
    return result;
}

int SumNumbersRec(int n)
{
    if (n == 0)
    {
        return 0;
    }
    else
    {
        return n + SumNumbersRec(n - 1);
    }
}

Console.WriteLine(SumNumbers(10));
Console.WriteLine(SumNumbersRec(10));
