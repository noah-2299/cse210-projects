

public class Activity{


private string _activityName;

private string _description;

private string _duration;

private DateTime _now = DateTime.Now;
private DateTime _endTime;

public void GetStartMessage(){
    Console.WriteLine("Welcome to the " + _activityName + ". ");
    Console.WriteLine();
    Console.WriteLine(_description);
    Console.WriteLine();
    Console.WriteLine("How long, in seconds, would you like for your session?");
}

public string GetEndMessage(){
    return "Goodbye";
}

public void SetDuration(string duration){
    _duration = duration;
    _endTime = _now.AddSeconds();
}

public Activity(string name, string description, string duration){
    _activityName = name;
    _description = description;
    _duration = duration;

}

public Activity(){
    _activityName = "_____";
    _description = "______";
    _duration = "_______";

}

}