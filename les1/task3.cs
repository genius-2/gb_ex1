
void ShowArrayReversed (int[] a, int i)
{
    if (i == 0 )
    {
        Console.Write(a[i]);
        return;
    }
    Console.Write($"{a[i]} ");
    ShowArrayReversed (a, i - 1);
}

int[] a = {1,2,3,4,5};
int i = a.Length - 1;
ShowArrayReversed(a, i);