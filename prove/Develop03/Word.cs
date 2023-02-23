using System;

public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public void Hide()
    {
        char[] characters = _word.ToCharArray();
        string hiddenWord = "";
        foreach (char item in characters)
        {
            hiddenWord += "_";
        }
        _word = hiddenWord;
        _isHidden = true;
    }
    public string GetWord(){
        return _word;
    }
    public bool GetStatus(){
        return _isHidden;
    }
}



