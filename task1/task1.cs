void ShowNumbers(int a, int b)
{
    if (a == b)
    {
        Console.WriteLine(a);
        return;
    }
    Console.WriteLine($"{a} ");
    a++;
    ShowNumbers(a, b);
}

Console.WriteLine("Введите натуральное N ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное M ");
int m = Convert.ToInt32(Console.ReadLine());
ShowNumbers(n, m);