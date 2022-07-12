Console.WriteLine("Write number n: ");
    while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals("exit"))
            Console.WriteLine("{0}->{1}",input, input[1]);
    }
