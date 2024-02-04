using System;
using System.Xml.Linq;

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
        Console.WriteLine("User Input: " + petChoice);

        //Check the type entered by User and show the response.
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
            return;
        }
        Console.WriteLine("What would you like to name your pet?");
        
        string petName = Console.ReadLine();
        Console.WriteLine("User Input: " + petName);

        Console.WriteLine("Welcome, "+ petName +"! Let's take good care of him.");

        int hunger = 0;
        int happiness = 0;
        int health = 0;

        //keep allowing user to select from menu until pressed exit.
        string menuSelection;
        do
        {
            //Give user choice to select from menu
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Feed " + petName);
            Console.WriteLine("2. Play with " + petName);
            Console.WriteLine("3. Let " + petName + " rest");
            Console.WriteLine("4. Check " + petName + "'s status");
            Console.WriteLine("5. Exit");

            menuSelection = Console.ReadLine();

            //On base of selection show the health, happiness and hunger.
            switch (menuSelection)
            {
                case "1":
                    hunger -= 1;
                    if (hunger < 0) hunger = 0;

                    health += 1;
                    if (health > 10) health = 10;

                    Console.WriteLine("Hunger decreased, health increased.");
                    break;
                case "2":
                    
                    break;
                case "3":
                    
                    break;
                case "4":
                    
                    break;
                case "5":
                    Console.WriteLine("Thank you for playing with " + petName + ". Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid menu selection.");
                    break;
            }
        } while (menuSelection != "5");
    }
}
