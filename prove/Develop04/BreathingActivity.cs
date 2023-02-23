public class BreathingActivity: Activity{
    private int _breathDuration = 4;
    
    public void Activate(){
        Console.WriteLine();
        Console.WriteLine("Breath In...");
        _countDown.Animate(_breathDuration);
        Console.WriteLine("Now breath Out...");
        _countDown.Animate(_breathDuration);
        Console.WriteLine();
    }
    public BreathingActivity()
    {
        _activityName = "Breathing Activity";
        _description =  "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";   
    }
}
