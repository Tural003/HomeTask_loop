let value = 10;
if (value == 0 || value == 1)
{
    console.log(value+ " sade deyil")
}
else
{
    for (let i = 2; i <= value / 2; i++)
    {
        if (value % i == 0)
        {
            console.log(value+ " sade deyil")
            return;
        }

    }
    console.log(value+ " sade ededdir")
}