using System;

class Program
{
    static void Main(string[] args)
    {
        string menuSelection = "";
        while (menuSelection != "4"){
            Console.WriteLine("Menu Options:"):
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select an item from the menu: ");
            menuSelection = Console.ReadLine();
            switch(menuSelection)
            {
                case "1":
                    BreathingActivity b1 = new BreathingActivity();

                    break;
                case "2":
                    ReflectionActivity r1 = new ReflectionActivity();

                    break;
                case "3":
                    ListingActivity l1 = new ListingActivity();
                    
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Please ensure your selection is on the menu:");
                    break;

            }
        }
    
    }
}