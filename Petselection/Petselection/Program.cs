using System;

class Program
{
    static void Main()
    {
        //Prompt user to choose a pet.
        Console.WriteLine("Choose a pet type:");
        Console.WriteLine("1. Cat");
        Console.WriteLine("2. Dog");
        Console.WriteLine("3. Rabbit");

        string petChoice = Console.ReadLine();

        if (petChoice == "1")
        {
            Console.WriteLine("You have selected a Cat as your pet.");
        }
        else if (petChoice == "2")
        {
            Console.WriteLine("You have selected a Dog as your pet.");
        }
        else if (petChoice == "3")
        {
            Console.WriteLine("You have selected a Rabbit as your pet.");
        }
        else {
            Console.WriteLine("Invalid choice");
        }

        
        
        
    }
}
