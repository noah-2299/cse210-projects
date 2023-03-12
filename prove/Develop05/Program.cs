using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        User user1 = new User();
        Menu mainMenu = new Menu();
        string userName ="";
        int currentPoints = 0;
        string choice = "";
        List<Goal> currentGoals = new List<Goal>();
        Console.WriteLine("Welcome to the Goal Setting Program,");
        Console.WriteLine("What is you name:");
        userName = Console.ReadLine();
        user1.SetName(userName);
        string filename = $"{user1.GetName()}.txt";
        while(choice != "6"){
            Console.WriteLine($"You have {currentPoints} points! That means you are rank {user1.GetRank()}"); // Need to add the rank to this string
            choice = mainMenu.Display();//should the menu change with rank? 
            switch(choice)
            {
                case "1":
                    //Print out the possible types of goals and get usert input
                    Console.WriteLine("Which Type of Goal would you like to make?");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write(">:");
                    string typeNumber = Console.ReadLine();
                    Console.WriteLine("What is the name of you goal:");
                    Console.Write(">:");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is a short description of you goal:");
                    Console.Write(">:");
                    string description = Console.ReadLine();
                    Console.WriteLine("How many point for completing this goal:");
                    Console.Write(">:");
                    string pointsInput = Console.ReadLine(); // I need to figure out how I want to convert this
                    // points need to be converted to correct data type
                    int points = int.Parse(pointsInput);

                    if (typeNumber == "1")
                    {
                        SimpleGoal simple = new SimpleGoal(name, description, points);
                        currentGoals.Add(simple);

                    }
                    else if (typeNumber == "2")
                    {
                        EternalGoal eternal = new EternalGoal(name, description, points);
                        currentGoals.Add(eternal);
                    }
                    else if (typeNumber == "3")
                    {
                        Console.WriteLine("How many times does repeating this goal give a bonus:");
                        string totalTimes = Console.ReadLine();
                        Console.WriteLine("How many bonus points:");
                        string bonusInput = Console.ReadLine();
                        int bonus = int.Parse(bonusInput);
                        ChecklistGoal checklist = new ChecklistGoal(name, description, points, totalTimes, bonus);
                        currentGoals.Add(checklist);
                    }
                    else
                    {
                        Console.Write("Please type a number on the menu");
                    }
                    break;
                case "2":
                    int i = 0;
                    for (i = 0; i<currentGoals.Count(); i++)
                    {
                        Console.Write($"{i+1}. ");
                        currentGoals[i].Display();
                    }
                    break;
                case "3":
                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        outputFile.WriteLine($"{currentPoints}, {user1.GetName()}");
                        foreach (Goal goal in currentGoals)
                        {
                        outputFile.WriteLine($"{goal.PrintGoalAsString()}");
                        }
                    }
                    break;
                case "4":
                    Console.WriteLine("Which File would you like to load?");
                    DirectoryInfo directory = new DirectoryInfo(@"C:\Users\N-Desk\Documents\GitHub\cse210-projects\prove\Develop05\");
                    FileInfo[] Files = directory.GetFiles("*.txt");
                    for (i=0; i < Files.Count(); i++)
                    {
                        FileInfo file = Files[i];
                        Console.WriteLine($"{i+1}. {file.Name}");
                    }
                    int fileNumber = int.Parse(Console.ReadLine())-1;
                    string fileString = Files[fileNumber].Name;
                    string[] lines = System.IO.File.ReadAllLines(fileString);
                    for (i=0; i< lines.Count();i++)
                    {
                        if(i==0)
                        {
                            string[] parts = lines[i].Split(",");
                            currentPoints = int.Parse(parts[0]);
                        }
                        else
                        {
                            string[] parts = lines[i].Split(",");
                            string typeFromFile = parts[0];
                            string nameFromFile = parts[1];
                            string descriptionFromFile = parts[2];
                            string pointsFromFile = parts[3];
                            int convertedPoints = int.Parse(pointsFromFile);
                            switch(typeFromFile)
                            {
                                case "Simple Goal":
                                    SimpleGoal simple = new SimpleGoal(nameFromFile,descriptionFromFile,convertedPoints);
                                    currentGoals.Add(simple);
                                    break;
                                case "Eternal Goal":
                                    EternalGoal eternal = new EternalGoal(nameFromFile,descriptionFromFile,convertedPoints);
                                    break;
                                case "Checklist Goal":
                                    int bonus = int.Parse(parts[4]);
                                    string totalTimes = parts[5];
                                    string repsComplete = parts[6];
                                    ChecklistGoal checklist = new ChecklistGoal(nameFromFile,descriptionFromFile,convertedPoints,totalTimes,bonus);
                                    checklist.SetTimesCompleted(repsComplete);
                                    currentGoals.Add(checklist);
                                    break;
                            }
                        }
                    }
                    break;
                case "5": 
                    Console.WriteLine("The Incomplete Goals are:");
                    for (i = 0; i < currentGoals.Count();i++)
                    {
                        if (currentGoals[i].GetCompleteStatus())
                        {
                            Console.WriteLine($"{i+1}. COMPLETE!");
                        }
                        else
                        {
                            string goalName = currentGoals[i].GetName();
                            Console.WriteLine($"{i+1}. {goalName}");
                        }
                        
                    }
                    Console.Write("Please enter the number of the goal to complete:");
                    int eventNumber = int.Parse(Console.ReadLine())- 1;
                    if (currentGoals[eventNumber].GetCompleteStatus())
                        {
                            Console.WriteLine($"That Goal was already complete! please create it again if you want to repeat it!");
                        }
                    else
                    {
                        currentPoints += currentGoals[eventNumber].CompleteGoal();
                        user1.SetPoints(currentPoints);
                        user1.CalculateRank();    
                    }
                    break;
                case "6":
                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        outputFile.WriteLine($"{currentPoints}, {user1.GetName()}");
                        foreach (Goal goal in currentGoals)
                        {
                        outputFile.WriteLine($"{goal.PrintGoalAsString()}");
                        }
                    }
                    break;
           }
        }
    }
}