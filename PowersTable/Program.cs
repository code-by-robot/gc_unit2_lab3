Console.WriteLine("Welcome to the Powers Table.");
int userinput = 0;
while (true)
{
    //Check input for range
    do
    {
        Console.WriteLine("Please enter an integer less than 1291.");
        userinput = int.Parse(Console.ReadLine());
    } while (userinput < 1 || userinput > 1290);

    //Write table
    Console.WriteLine("Input\t\tSquare\t\tCube");
    for (int i = 1; i <= userinput; i++)
    {
        int square = i * i;
        int cube = i * i * i; //Could have also used Math.Pow(i, 3)
        Console.WriteLine($"{i,16}{square,16}{cube,16}");
    }
    
    //Ask to continue
    Console.WriteLine("Would you like to enter a new number? yes/no");
    string response = Console.ReadLine();
    if(response.ToLower() != "yes")
    {
        break;
    }
}

