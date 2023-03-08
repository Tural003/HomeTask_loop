let from = 2;
let to = 12;
for (let i = from; i <= to; i++)
{
    let count = 0;
    for (let j = 2; j <= i / 2; j++)
    {
        if (i % j == 0)
        {
            count++;
            break;
        }
    }

    if (count == 0 && i != 1)
    {
        console.log(i)
    }
}