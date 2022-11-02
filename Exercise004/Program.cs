int a = 24;
int b = 19;
int c = 25;

int max;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}
if (max < c)
{
    max = c;
}

Console.Write("Наибольшее число - ");
Console.WriteLine(max);