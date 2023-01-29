using System.IO;
public class journal{

    public List<entry> _entriesList = new List<entry>();

    public List<string> _prompts = new List<string>();
        
    public void Write(){
        Random rand = new Random();
        int promptIndex = rand.Next(_prompts.Count);
        string prompt = _prompts[promptIndex];
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        entry entry = new entry();
        entry._dateRecorded = "Date: " + DateTime.Now.ToShortDateString();
        entry._prompt = "Prompt: " + prompt;
        entry._response = "Response: " +response;
        _entriesList.Add(entry);
    }



    public void Display(){
        Console.WriteLine("Journal Entries:");
        foreach (entry entry in _entriesList)
        {
            Console.WriteLine($"Date: {entry._dateRecorded}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"Response: {entry._response}");
            Console.WriteLine();
        }
    }

    public void Load(string fileName){
        _entriesList.Clear();
        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                string date = reader.ReadLine();
                string prompt = reader.ReadLine();
                string response = reader.ReadLine();
    
                entry entry = new entry();
                entry._dateRecorded = date;
                entry._prompt = prompt;
                entry._response = response;
                _entriesList.Add(entry);
            }
        }
    }

    
    public void Save(string fileName){
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (entry entry in _entriesList)
            {
                outputFile.WriteLine(entry._dateRecorded);
                outputFile.WriteLine(entry._prompt);
                outputFile.WriteLine(entry._response);
            }
        }

    }
}