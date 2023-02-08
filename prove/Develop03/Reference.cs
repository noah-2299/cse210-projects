using System;

public class Reference {
    private string _book;
    private string  _chapter;
    private string _verse;
    
    public Reference(){
    _book = "Proverbs ";
    _chapter = "3:";
    _verse = "5-6";
    }
    public Reference(book, chapter, verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }


}