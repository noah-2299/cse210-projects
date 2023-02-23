public class ReflectionActivity: Activity{
    
    private List<string> _prompts = new List<string> 
    {
        "---Think of a time when you stood up for someone else.---",
        "---Think of a time when you did something really difficult.---",
        "---Think of a time when you helped someone in need.---",
        "---Think of a time when you did something truly selfless.---"
    };
    private List<string> _questions = new List<string> 
    {
        "> Why was this experience meaningful to you?",
        "> Have you ever done anything like this before?",
        "> How did you get started?",
        "> How did you feel when it was complete?",
        "> What made this time different than other times when you were not as successful?",
        "> What is your favorite thing about this experience?",
        "> What could you learn from this experience that applies to other situations?",
        "> What did you learn about yourself through this experience?",
        "> How can you keep this experience in mind in the future?",
    };
    private HashSet<string> _chosen = new HashSet<string>();
    private string _prompt = "";

    private string _question = "";

    private Random _r = new Random();


    


     public void Start(){    
        _prompt = _prompts[_r.Next(_prompts.Count)];
        Console.WriteLine("Consider the following Prompt:");
        Console.WriteLine();
        Console.WriteLine(_prompt);
        Console.WriteLine("When you Have Something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder the following questions as they related to this experience.");
        Console.WriteLine("You may begin in:");
        _animation.CountDown(3);
        Console.Clear();
          
    }
    public void Question()
    {
        do {
        _question = _questions[_r.Next(_questions.Count)];
        } while (_chosen.Contains(_question));
        _chosen.Add(_question);
        if (_chosen.Count == _questions.Count) 
            {
            _chosen.Clear();
            }
        Console.WriteLine(_question);
        _animation.Spin(6);
    }


    public ReflectionActivity(){
        _activityName = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    }
}