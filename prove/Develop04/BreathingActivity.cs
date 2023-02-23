public class BreathingActivity: Activity{
    private int _breathDuration = 6;
    
    public void Activate(){
        Console.WriteLine();
        Console.Write("Breath In...");
        _animation.CountDown(_breathDuration);
        Console.WriteLine();
        Console.Write("Now breath Out...");
        _animation.CountDown(_breathDuration);
        Console.WriteLine();
    }
    public BreathingActivity()
    {
        _activityName = "Breathing Activity";
        _description =  "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";   
    }
}
