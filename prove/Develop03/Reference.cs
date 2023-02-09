using System;

public class Reference
{
private string _book;
private string _chapter;
private List<int> _verseList;

public Reference(string book, string chapter, List<int> verses){
    _book = book;
    _chapter = chapter;
    _verseList = verses;
}
public Reference(){
    _book = "Nephi";
    _chapter = "1";
    _verseList = new List<int> {1,2};
}




}