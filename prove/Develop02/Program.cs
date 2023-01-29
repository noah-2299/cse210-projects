using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        journal journal = new journal();

        journal._prompts.Add("Who was the most interesting person I interacted with today?");
        journal._prompts.Add("What was the best part of my day?");
        journal._prompts.Add("How did I see the hand of the Lord in my life today?");
        journal._prompts.Add("What was the strongest emotion I felt today?");
        journal._prompts.Add("If I had one thing I could do over today, what would it be?");


        static void MenuPrint(){
            Console.WriteLine("Please select your choice");
            Console.WriteLine("1. Write Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Load Journal");
            Console.WriteLine("4. Save Journal");
            Console.WriteLine("5. Quit");
            
        }
    
        string choice = "";
        while (choice != "5")
        {
            MenuPrint();
            choice = Console.ReadLine();

            if (choice == "1")
            {
                journal.Write();
            }
            else if (choice == "2")
            {
                journal.Display();
            }
            else if(choice == "3")
            {
                Console.WriteLine("What file name:");
                string file = Console.ReadLine();
                journal.Load(file);
            }
            else if(choice == "4")
            {
                Console.WriteLine("What file name:");
                string file = Console.ReadLine();
                journal.Save(file);
            }
            else if(choice == "5")
            {
                Console.WriteLine("Thank you for journaling today! Come back soon!");
                break;
            }
            else
            {
                Console.WriteLine("Sorry, please use a number listed in the menu to select your choice!");
            }


        }
    }
}
            