Console.Write("Write number N: ");
int n = int.Parse(Console.ReadLine());

if (n > 999 ^ n < 100)
{
    Console.Write("error");
}
else
{
    Console.WriteLine(n % 100 / 10);
}


//Console.WriteLine(" Write number:");
//    while(true)
//    {
//        string input = Console.ReadLine();
//        if(!input.Equals("exit"))
//            Console.WriteLine("{0}->{1}",input, input[1]);
//        else
