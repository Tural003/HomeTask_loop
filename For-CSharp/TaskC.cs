int value = 3;
if (value == 0 || value == 1)
{
    Console.WriteLine(value + " sade deyil");
}
else
{
    for (int i = 2; i <= value / 2; i++)
    {
        if (value % i == 0)
        {
            Console.WriteLine(value + " sade deyil");
            return;
        }

    }
    Console.WriteLine(value + " sade ededdir");
}