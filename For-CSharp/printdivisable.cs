int n = 50;
for (int i = 0; i <= n; i++)
{
    if (i % 3 == 0 || i % 5 == 0 || i % 6 == 0)
    {
        Console.WriteLine(i);
    }
}