using System;

public class Word
{
    private string _word;
    private bool isHidden;

    public Word(string word)
    {
        _word = word;
        isHidden = false;
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
        isHidden = true;
    }
    public string GetWord(){
        return _word;
    }
    
}



