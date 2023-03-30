using System;

class Program
{
    static void Main(string[] args)
    {
        //Creating the details for lectureEvent1

        DateOnly feb1 = new DateOnly(2023,2,1);
        TimeOnly noon = new TimeOnly(12,0,0);
        Address mainHall = new Address("525 S Center St", "Rexburg","Idaho", "United States");
        Lecture lectureEvent1 = new Lecture("The Fundementals of C#", "Brother Poulson speaks on language of C# for the total novice!", feb1, noon, mainHall, "Proffesor Vaughn Poulson", 100);
        //Printing Messages
        Console.WriteLine("Event 1 messages:");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine(lectureEvent1.StandardDetails());
        Console.WriteLine("-------------------------------------");
        Console.WriteLine(lectureEvent1.FullDetails());
        Console.WriteLine("-------------------------------------");
        Console.WriteLine(lectureEvent1.ShortDescription());
        Console.WriteLine("-------------------------------------");

        //Creating the details for ReceptionEvent2
        DateOnly receptionDate = new DateOnly(2023,5,5);
        TimeOnly receptionTime = new TimeOnly(15,30,0);
        Address receptionAddress = new Address("399 Apple Pie Ridge Rd", "Winchester","Virginia", "United State");
        Reception receptionEvent2 = new Reception("Wedding Reception of Happy Couple!", "Join the Happy couple to celebrate their happily ever after.", receptionDate, receptionTime, receptionAddress, "rsvp@reception.com");
        Console.WriteLine("Event 2 messages:");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine(receptionEvent2.StandardDetails());
        Console.WriteLine("-------------------------------------");
        Console.WriteLine(receptionEvent2.FullDetails());
        Console.WriteLine("-------------------------------------");
        Console.WriteLine(receptionEvent2.ShortDescription());
        Console.WriteLine("-------------------------------------");

        //Creating the details for OutdoorEvent3
        DateOnly OutdoorDate = new DateOnly(2023,7,20);
        TimeOnly OutdoorTime = new TimeOnly(9,45,0);
        Address OutdoorAddress = new Address("1254 Example ln", "Atlanta","Georgia", "United States");
        Outdoor OutdoorEvent3 = new Outdoor("Company Picnic", "Come join us for games, food, prizes and more! Bring your family to this fun filled Day!", OutdoorDate, OutdoorTime, OutdoorAddress, "Slightly Overcast, 5% Chance of Rain");
        
        Console.WriteLine("Event 3 Messages: ");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine(OutdoorEvent3.StandardDetails());
        Console.WriteLine("-------------------------------------");
        Console.WriteLine(OutdoorEvent3.FullDetails());
        Console.WriteLine("-------------------------------------");
        Console.WriteLine(OutdoorEvent3.ShortDescription());
        Console.WriteLine("-------------------------------------");

    }
}