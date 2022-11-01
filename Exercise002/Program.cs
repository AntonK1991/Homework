int a = -9;
int b = -3;
int max;
int min;

if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}

Console.Write("Наибольшее число - ");
Console.WriteLine(max);

Console.Write("Наименьшее число - ");
Console.WriteLine(min);