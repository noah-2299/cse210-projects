using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string section, string problems, string name,string topic) : base(name,topic)
    {
        _problems = problems;
        _textbookSection = section;

    }
    public string GetHomeworkList()
    {
        return _textbookSection + " " + _problems;
    }

}