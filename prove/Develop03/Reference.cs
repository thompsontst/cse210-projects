using System;
public class Reference{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _startVerse;
    private int _endVerse;
   public Reference ( string book, int chapter,  int verse) 
{
    _book = book;
    _chapter = chapter;
    _verse = verse;
}
   public Reference ( string book, int chapter,  int startVerse,  int endverse) 
{
    _book = book;
    _chapter = chapter;
    _startVerse = startVerse;
    _endVerse = endverse;
}
public string GetDisplayText ()
{
return string.Format("{0} {1}: {2} - {3}:", _book, _chapter, _startVerse, _endVerse);
}

}