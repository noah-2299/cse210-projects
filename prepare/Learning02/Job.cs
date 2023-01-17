public class Job
    {
        public string _company = "";
        public string _jobTitle = "";

        public string _startYear = "";
        public string _endYear = "";

        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }

    
    }
