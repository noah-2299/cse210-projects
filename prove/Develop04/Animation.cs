
public class Animation{

        private string[] _spin = { "/", "-", "\\", "|" };
        private string[] _breath = { ".", "o", "O", "o"};
        private string[] _count = {"4","3","2","1"};
        private string[] _sequence;
        private int _interval = 400;
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
        public Animation(int type)
        {
            switch (type)
            {
                case 0:
                    _sequence = _spin;
                    _interval = 300;
                    break;
                case 1:
                    _sequence = _breath;
                    _interval = 600;
                    break;
                case 2:
                    _sequence = _count;
                    _interval = 1000;
                    break;
            }
        }
        public void SetStringArray(string[] sequence)
            {
                _sequence = sequence;
            }
        

 


}