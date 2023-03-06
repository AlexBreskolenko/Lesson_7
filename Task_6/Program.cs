//Обход структур с вычеслением времени работы
Console.Clear();

//Начальное время
DateTime dt = DateTime.Now;

string emp = String.Empty;

string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                 0    1    2     3    4    5    6    7    8    9    10   11

void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        //вычесляем левую сторону
        int left = 2 * pos;
        //вычеслям правую сторону
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left]))
        {
            InOrderTraversal(left);
        }
        Console.Write($"{tree[pos]} ");
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right]))
        {
            InOrderTraversal(right);
        }
    }
}

InOrderTraversal();
Console.WriteLine();
//Вычисляем время в миллисекундах
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
