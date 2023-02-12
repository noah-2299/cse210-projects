using System;

public class Scripture {
    private Reference _ref;
    private List<Word> _wordList;
    private string _rawText;


    public Scripture()
    {
        _ref = new Reference();
        _wordList = new List<Word>();
        _rawText = "I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days. 2 Yea, I make a record in the alanguage of my father, which consists of the learning of the Jews and the language of the Egyptians. 3 And I know that the record which I make is true; and I make it with mine own hand; and I make it according to my knowledge.";
        foreach (string i in _rawText.Split(" ")) {
            Word chunk = new Word(i);
            _wordList.Add(chunk);
        }
    }
    
    public void RenderText()
    {
        string renderString = "";
        foreach (Word i in _wordList){
            renderString += i.GetWord() + " ";
        }
        Console.WriteLine(renderString);
    }
    public void HideWords(){
        for (int i = 0; i < 2; i++)
        {
        Random rand = new Random();
        int index = rand.Next(_wordList.Count);
        if (_wordList[index].GetStatus())
        {
            i--;
        }
        else
        {
            _wordList[index].Hide();
        }
         
        }
    }
    public bool FullyHidden(){
        int length = _wordList.Count();
        int counter = 0;
        foreach (Word word in _wordList){
            if (word.GetStatus())
            {
                counter += 1;
            }
        }
        if (counter >= length){
            return false;
        }
        else{
            return true;
            
        }
    }
}