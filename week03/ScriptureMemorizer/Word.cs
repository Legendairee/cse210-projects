using System.Text;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            StringBuilder hiddenWord = new StringBuilder();

            foreach (char character in _text)
            {
            
                if (char.IsLetterOrDigit(character))
                {
                    hiddenWord.Append('_');
                }
                else
                {
                    hiddenWord.Append(character);
                }
            }

            return hiddenWord.ToString();
        }

        return _text;
    }
}