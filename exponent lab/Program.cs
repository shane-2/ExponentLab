using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

Console.WriteLine("Do you want to enter the exponent lab? y/n");
string answer = Console.ReadLine().ToLower().Trim();

if (answer == "y")
{
    int x = -1;
    do
    {
        Console.WriteLine("Welcome to the exponent lab! Please provide a whole number");
        int userNum = int.Parse(Console.ReadLine());

        if (userNum > 0 && userNum < 1291)
        {
            Console.WriteLine(string.Format("{0, 10} {1, 10} {2,10}", "Number", "Squared", "Cubed"));

            for (int i = 1; i <= userNum && i >= 1; i++)
            {
                
                Console.WriteLine(string.Format("{0, 10} {1, 10} {2, 10}", (i), squared(i), cubed(i)));
                
            }
            
        }
        Console.WriteLine("would you like to go again? y/n");
        string cont = Console.ReadLine().ToLower().Trim();
        if (cont == "n")
            x++;
    }
    while (x != 0);
    
}
else
{
    Console.WriteLine("Goodbye!");
}




    static int squared(int i)
    {
        return i * i;
    }
    static int cubed(int i)
    {
        return i * i * i;
    }



