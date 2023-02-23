using System;

class Program
{
    static void Main(string[] args)
    {
        // Creation of the string to compare to for menu selection, as well as the ojects for each activity class that will be used
        string menuSelection = "";
        BreathingActivity breathing = new BreathingActivity();
        ReflectionActivity reflecting = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();
        while (menuSelection != "4"){
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an item from the menu:");
            menuSelection = Console.ReadLine();
            //handling the selections that might be made by the user
            switch(menuSelection) 
            {
                case "1":
                    // The method GetStartMessage handles Writing the Start message for any Activity and handles Reading the seconds that user wants to run the actitity and stores it.
                    breathing.GetStartMessage();
                    // Each activity does not have the duration start until right before the loop of the main body of the activity using this method. 
                    breathing.SetEndTime();
                    while (breathing.HasTime()) // HasTime method returns boolean based on a comparison of now and the end time set in the step previous. 
                    {
                        breathing.Activate();
                    }
                    breathing.GetEndMessage(); //This method prints the end of the activity.
                    break;
                case "2":
                    reflecting.GetStartMessage();
                    reflecting.Start(); // Unlike breathing activity, this has one time steps that happen before the main loop of the activity, but are not univeral to other activities and cannot be shared.  
                    reflecting.SetEndTime(); // The timer of the activity does not start until the user has entered the main loop. This limits short times from not even getting to the loop.
                    while (reflecting.HasTime())
                    {
                        reflecting.Question();
                    }
                    reflecting.GetEndMessage();
                    break;
                case "3":
                    listing.GetStartMessage();
                    listing.Start();
                    listing.SetEndTime();
                    while (listing.HasTime())
                    {
                        // In showing creativity to the requirements this method ensures that the random questions are fully run through before they start again. 
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
