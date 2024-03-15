int akr(int a, int b)
{
    if (a == 0) return b + 1;
    else if (b == 0) return akr(a - 1, 1);
    return akr(a - 1, akr(a, b - 1));
}
Console.WriteLine("Введите а: ");
int a = Convert.ToInt32(Console.R
eadLine());
Console.WriteLine("Введите b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Аккерман = {akr(a, b)}");