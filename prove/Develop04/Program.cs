using System;

class Program
{
    static void Main(string[] args)
    {
        
        string menuSelection = "";
        BreathingActivity breathing = new BreathingActivity();
        ReflectionActivity reflecting = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();
        while (menuSelection != "4"){
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an item from the menu: ");
            menuSelection = Console.ReadLine();
            switch(menuSelection) 
            {
                case "1":
                    breathing.GetStartMessage();
                    breathing.setEndTime();
                    while (breathing.HasTime())
                    {
                        breathing.Activate();
                    }
                    breathing.GetEndMessage();
                    break;
                case "2":
                    reflecting.GetStartMessage();
                    reflecting.Start();
                    reflecting.setEndTime();
                    while (reflecting.HasTime())
                    {
                        reflecting.Question();
                    }
                    reflecting.GetEndMessage();
                    break;
                case "3":
                    listing.GetStartMessage();
                    listing.Start();
                    listing.setEndTime();
                    while (listing.HasTime())
                    {
                        listing.List();
                    }
                    listing.TotaledEntries();
                    listing.GetEndMessage();
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
