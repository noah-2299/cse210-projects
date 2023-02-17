
public class Animation{

        //sequence = new string[] { "/", "-", "\\", "|" };
        //sequence = new string[] { ".", "o", "O", "o"};
        //sequence = new string[] { "+", "x" };
        //sequence = new string[] { "V", "<", "^", ">" };
        //sequence = new string[] { ".   ", "..  ", "... ", "...." };
        private string[] _sequence = {"1","2","3","4","5","6"};  //{ ".", "o", "O", "o"};
        private int _interval = 1000;
        private DateTime _now = DateTime.Now;
        private DateTime _endTime;

        public void Animate(int duration){
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


 


}