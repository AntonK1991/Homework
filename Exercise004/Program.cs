int a = 8;
int b = 19;
int c = -5;

int max = a;

if (max > b)
{
    if (max < c)
    {
        max = c;
    }
}
else
{
    max = b;
    if (max < c)
    {
    max = c;
    }
}

Console.Write("Наибольшее число - ");
Console.WriteLine(max);