public class ListingActivity: Activity{

    private List<string> _prompts = new List<string> 
    {
        "---Who are people that you appreciate?---",
        "---What are personal strengths of yours?---",
        "---Who are people that you have helped this week?---",
        "---When have you felt the Holy Ghost this month?---",
        "---Who are some of your personal heroes?---",

    };
    private string _prompt = ""; 
    private int _counter = 0;
    private Random _r = new Random();

    

     public void Start(){
        _prompt = _prompts[_r.Next(_prompts.Count)];
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine(_prompt);
        Console.WriteLine("You may begin in:");
        _countDown.Animate(4);
     }
     public void List()
     {
        Console.Write(">");
        Console.ReadLine();
        _counter += 1;
     }
     public void TotaledEntries()
    {
        Console.WriteLine($"You listed {_counter} items!");
    }
    public ListingActivity(){
        _activityName = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
}