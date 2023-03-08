using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Menu mainMenu = new Menu();
        User user1 = new User();

        string choice = "";
        string filename = "GoalInfo.txt";
        List<Goal> currentGoals = new List<Goal>();
        int currentPoints = 0;
        while(choice != "6"){
            Console.WriteLine($"You have {currentPoints} points!");
            choice = mainMenu.Display();
            switch(choice)
            {
                case "1":
                    Console.WriteLine("Which Type of Goal would you like to make?");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write(">:");
                    string typeNumber = Console.ReadLine();
                    Console.Write("What is the name of you goal:");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of you goal:");
                    string description = Console.ReadLine();
                    Console.Write("How many point for completing this goal:");
                    string pointsInput = Console.ReadLine(); // I need to figure out how I want to convert this
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
                    //What type of Goal would you like to make
                    // based on which type of goal that they choose gather the information for that goal
                    //Create that goal with all the details
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
                        outputFile.WriteLine($"{currentPoints}");
                        foreach (Goal goal in currentGoals)
                        {
                        outputFile.WriteLine($"{goal.PrintGoalAsString()}");
                        }
                    }
                    break;
                case "4":
                    string[] lines = System.IO.File.ReadAllLines(filename);
                    
                    for (i=0; i< lines.Count();i++)
                    {
                        if(i==0)
                        {
                            currentPoints = int.Parse(lines[i]);
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
                                    string bonus = parts[4];
                                    int totalTimes = int.Parse(parts[5]);
                                    string repsComplete = parts[6];
                                    ChecklistGoal checklist = new ChecklistGoal(nameFromFile,descriptionFromFile,convertedPoints,bonus,totalTimes);
                                    checklist.SetTimesCompleted(repsComplete);
                                    currentGoals.Add(checklist);
                                    break;
                            }
                        }

                    }
                    break;
                case "5":
                    // Display all the current goals, ask for a user selecetion and then award and display points accociated
                    
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
                    }
                    break;
           }
        }

    }
}