using System;

class Program
{
    static void Main(string[] args)
    {
    Scripture nephi = new Scripture();
    string quit = "";
    bool fullyHidden = false;
    while (quit != "quit" && fullyHidden == false){
    Console.Clear();
    nephi.RenderText();
    nephi.HideWords();
    quit = Console.ReadLine();
    fullyHidden = nephi.fullyHidden();
    Console.Clear();
    }
    }
}