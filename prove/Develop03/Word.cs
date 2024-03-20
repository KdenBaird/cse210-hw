using System;

public class CBWord
{
    //Attributes
    private string _word;
    private bool _isHidden;

    //Methods:
    public bool GetIsHidden()
    {
        return _isHidden;
    }
    
    public string GetWord() {
        return _word;
    }

    public void SetWord(string value) {
        _word = value;
    }

    public void HideWord()
    {
        _isHidden = true;
    }
}