using System;

public class Menu 
{
    protected List<string> _optionsList = new List<string>()
    {
        "Create New Goal",
        "List Goals",
        "Save Goals",
        "Load Goals",
        "Record Event",
        "Save and Quit"
    };
    private string _selection;

    public string Display()
    {
        Console.WriteLine("Please select one of the following choices:");
        for (int i = 0; i < _optionsList.Count(); i++)
        {
            string print = (i+1).ToString() + ". " + _optionsList[i];
            Console.WriteLine(print);
        }
        Console.Write(">:");
        _selection = Console.ReadLine();
        return _selection;
    }
    public string GetSelection()
    {
        return _selection;
    }
    public void SetSelection(string selection)
    {
        _selection = selection;
    }
}