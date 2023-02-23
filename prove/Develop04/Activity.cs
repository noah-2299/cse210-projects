

public class Activity{

protected string _activityName = "";
//In this case it seemed to be best to set this as protected and use it in the default constructors of the children classes. That way there is no Public Setter method that migth allow other parts of the program to set activity names, as well as by default whenever a child activty is made it always sets these to be the approprate values.
protected string _description = "";

private DateTime _now;
private DateTime _endTime;

//By storing the string inputed by the user it can be dirrectly plugged into the Ending message and only converted once when evaluating the seconds to add to the DateTime
private string _durationString;

//All activies types will use an Animation so it is set here and called appropriately by each activity
protected Animation _animation = new Animation();


public void GetStartMessage(){
    Console.Clear();
    Console.WriteLine("Welcome to the " + _activityName + ". ");
    Console.WriteLine();
    Console.WriteLine(_description);
    Console.WriteLine();
    Console.Write("How long, in seconds, would you like for your session?");
    _durationString = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Get Ready!");
    _animation.Spin(2);
}

public void GetEndMessage(){
    Console.WriteLine("Well done!");
    _animation.Spin(2);
    Console.WriteLine();
    Console.WriteLine($"You have completed a {_durationString} seconds of the {_activityName}");
    _animation.Spin(2);
}
public void SetEndTime(){
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
}
