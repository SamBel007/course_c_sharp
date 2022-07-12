void num1(int a, int b)
{
    if (a % b == 0)
        Console.WriteLine("кратно");
    else
    {
        Console.WriteLine($"не кратно {a % b}");
    }
}
num1(18, 3);
