using System;

class Program
{
    static void Main(string[] args)
    {
        
        Video vid1 = new Video("C# Tutorial - Full Course for Beginners", 16268,"freeCodeCamp.org");
            vid1.AddComment("DATOneDoctor-Archives", "The fact that this man spent 4 hours teaching code and doesnt add ads so we the viewers could learn.  Mad respect my man.");
            vid1.AddComment("Annelies van Hagen","Finally found someone who doesnt skip steps explaining, so even people like me not knowing anything about programming can follow. Thank you Mike");
            vid1.AddComment("Pain1272","Only 1 hour in and Im learning so much better than any teacher in school Ive ever had… you break this down into such an easier way of understanding it");
        Video vid2 = new Video("C# in 100 Seconds", 146, "Fireship");
            vid2.AddComment("Hares Mahmood","C# is just really comfortable to work with imo - it's always felt like the better version of Java to me");
            vid2.AddComment("Maulana iman","what I like from C# is the documentation in Microsoft website, it's so clear step by step. also the community is awesome.");
            vid2.AddComment("MechMK1","It should be noticed that destructors are very uncommon in C#, unlike C++.");
        Video vid3 = new Video("C# Tutorial For Beginners - Learn C# Basics in 1 Hour", 3600,"Programming with Mosh ");
            vid3.AddComment("MLM","I've been looking for a tutorial like this for weeks. You seem to be the only guy ON INTERNET who doesn't take anything for granted and actually explains every single aspect of the programming language with knowledge and clarity. Most people don't understand that even the smallest insignificant detail could be very confusing for a neophyte if they don't explain what it does and why it behaves that way. Thanks for going so in depth on each topic!");
            vid3.AddComment("EngineersToolkit","Hey great job Mosh, this was my very first foray in the C# (coming from a VBA background), and this was exactly what I was looking for. Very comprehensive, well thought through tutorial; thank you for sharing, and keep up the great work :)");
            vid3.AddComment("Eric Moore","Wow this is fantastic.  I've started and not finished a LOT of C++ and C# tutorials.  I have no doubt that I will finish this and many of your other course offerings.  This is exactly what a beginner needs.  I can't wait to watch more.");
        Video vid4 = new Video("C# GUI | C# GUI Project | C# GUI Tutorial | Learn C# | C# Programming Tutorial | Simplilearn", 1422,"Simplilearn");
            vid4.AddComment("BerbX","thank you so much this helped a lot.");
            vid4.AddComment("MJ MJ","Thank you");
            vid4.AddComment("Anup Nadagouda","Do more videos on C#");
        List<Video> videos = new List<Video>(){vid1,vid2,vid3,vid4};
        int counter = 0;
        foreach (Video vid in videos)
        {
            counter++;
            Console.Write($"{counter}. ");
            vid.PrintDetails();
            Console.WriteLine($"Number of Comments: {vid.GetNumberOfComments()}");
            vid.PrintComments();
        }
    }
}