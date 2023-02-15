using System;

public class Word
{
    private string _word;
<<<<<<< HEAD
    private bool isHidden;
=======
    private bool _isHidden;
>>>>>>> dc751b9f590df9953c2e08027e4e182ea84f88c2

    public Word(string word)
    {
        _word = word;
<<<<<<< HEAD
        isHidden = false;
=======
        _isHidden = false;
>>>>>>> dc751b9f590df9953c2e08027e4e182ea84f88c2
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
<<<<<<< HEAD
    
=======
    public bool GetStatus(){
        return _isHidden;
    }
>>>>>>> dc751b9f590df9953c2e08027e4e182ea84f88c2
}



