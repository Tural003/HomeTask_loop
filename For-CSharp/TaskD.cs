int from = 2;
int to = 12;
for (int i = from; i <= to; i++)
{
    int count = 0;
    for (int j = 2; j <= i / 2; j++)
    {
        if (i % j == 0)
        {
            count++;
            break;
        }
    }

    if (count == 0 && i != 1)
    {
        Console.Write("{0} ", i);
    }
}