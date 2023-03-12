public class User
{
    private string _userName;
    private int _points;
    private string _rank = "Starter";
    private string _filename;
    
    private string[] _rankList = 
        {
        "Starter",
        "Go Getter",
        "Goal Setter",
        "Pro",
        "Disciplined",
        "!!Expert!!",
        };
    public string GetName(){
        return _userName;
    }
    public void SetName(string name)
    {
        _userName = name;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public void CalculateRank()
    {
        if (_points < 100)
        {
            _rank = _rankList[0];
        }
        else if (_points < 300)
        {
            _rank = _rankList[1];
        }
        else if (_points < 500)
        {
            _rank = _rankList[2];
        }
        else if (_points < 800)
        {
            _rank = _rankList[3];
        }
        else if (_points < 1000)
        {
            _rank = _rankList[4];
        }
        else if (_points < 1500)
        {
            _rank = _rankList[5];
        }
    }
    public string GetRank()
    {
        return _rank;
    }
}