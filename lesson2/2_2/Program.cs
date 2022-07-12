int MaxDigit(int num)
{
    if (num / 10 > num % 10)
        return num / 10;
    else
        return num % 10;
}
int a = new Random().Next(10,100);
Console.WriteLine(a);
Console.WriteLine(MaxDigit(a));