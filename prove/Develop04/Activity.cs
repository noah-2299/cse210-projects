

public class Activity{

protected string _activityName = "_____";

protected string _description = "______";

private DateTime _now;
private DateTime _endTime;

private string _durationString;

protected Animation _spinner = new Animation(0);
protected Animation _breather = new Animation(1);
protected Animation _countDown = new Animation(2);


public void GetStartMessage(){
    Console.Clear();
    Console.WriteLine("Welcome to the " + _activityName + ". ");
    Console.WriteLine();
    Console.WriteLine(_description);
    Console.WriteLine();
    Console.WriteLine("How long, in seconds, would you like for your session?");
    _durationString = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Get Ready!");
    _spinner.Animate(3);
}

public void GetEndMessage(){
    Console.WriteLine("Well done!");
    Console.WriteLine();
    Console.WriteLine($"You have completed a {_durationString} seconds of the {_activityName}");
    _durationString = "";
    
}
public void setEndTime(){
    _now = DateTime.Now;
    _endTime = _now.AddSeconds(int.Parse(_durationString));
}


public bool HasTime(){
    _now = DateTime.Now;
    if (_now < _endTime)
    {
        return true;
    }
    return false;
}
public Activity(){
     _activityName = "------" ;
     _description = "------";
 }

}
