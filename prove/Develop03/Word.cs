using System;

public class Word
{
    private string _word;
    private bool isHidden = false;

    public Word(string word)
    {
        _word = word;
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
}



