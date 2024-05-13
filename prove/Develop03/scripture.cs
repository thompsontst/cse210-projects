using System;

class Scripture

{ 
    private string _textOfScripture;
    private Reference _reference;

public Scripture (Reference scriptureReference, string textOfScripture)
{
    _reference = scriptureReference;
    _textOfScripture = textOfScripture;
}
public string GetDisplayText()
{
    return string.Format("{0}", _textOfScripture);
}
}