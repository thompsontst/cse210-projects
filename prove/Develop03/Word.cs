using System;
class Word {
    private Scripture _scripture;
    private List<string> _listOfScriptureText;
    private int _wordsDeleted = 0;
   
    public Word (Scripture scripture)
    {
  _scripture = scripture;
  _listOfScriptureText = new List<string>();
  Show();


    }
  public void Show()
  {
_listOfScriptureText = _scripture.GetDisplayText().Split(" ").ToList();
  }
public void Hide()
{
    int quanToHide = 3;
    int wordsToHide = 0;

    do {
        int wordIndex = new Random().Next(0, _listOfScriptureText.Count());
        if (_listOfScriptureText[wordIndex].Contains('_') == false)
        {
            _listOfScriptureText[wordIndex] = new string('_', _listOfScriptureText[wordIndex].Length);
            wordsToHide++;
            _wordsDeleted++;
        
        if (( _listOfScriptureText.Count() - quanToHide) <= _wordsDeleted && _wordsDeleted < (_listOfScriptureText.Count() + 1))
        {
           wordsToHide = 3;
        }

    }
    } while(wordsToHide != quanToHide);
}
public string GetDisplayText()
{
    return string.Join(" ", _listOfScriptureText);
}
public bool IsHidden()
{
    bool hideWords = false;
    foreach (string word in _listOfScriptureText)
    {
        if(word.Contains("_") == false)
        {
            hideWords = true;
            break;
        }
    }
    return hideWords;
}

}
