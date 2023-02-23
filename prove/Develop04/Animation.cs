
public class Animation{

        private string[] _sequence = { "|","/", "-", "\\", "|","/", "-", "\\"};
        private int _interval = 300;
        private DateTime _now = DateTime.Now;
        private DateTime _endTime;

        public void Spin(int duration)
        {
            // by using the same method of setting start and end time, the interval between the characters and the charaters themselves can be adjusted without breaking the animation.
            _now = DateTime.Now;
            _endTime = DateTime.Now.AddSeconds(duration);
            while (_now < _endTime)
            {
                foreach (string i in _sequence){
                    Console.Write(i);
                    Thread.Sleep(_interval);
                    Console.Write("\b \b");
                }
                _now = DateTime.Now;
            }
        }
        public void CountDown(int max)//This allows counting down from a Maxium number where the interval is always 1 second.
        {
                for (int i = max; i > 0; i--){
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
        }
 
}