Console.Write("Enter N: ");
int a=int.Parse(Console.ReadLine());
int Cube(int a)
{
    int i=1;
    for(i=1;i<=a;i++)
        Console.Write($"{Math.Pow(i,3)} ");
    return(0);
}
Cube(a);
