using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string cleanText = text.Replace("\r", "").Replace("\n", " ");
        string[] splitText = cleanText.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string wordText in splitText)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        List<int> visibleIndices = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndices.Add(i);
            }
        }

        int wordsToHide = Math.Min(numberToHide, visibleIndices.Count);
        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex = random.Next(visibleIndices.Count);
            int selectedWordIndex = visibleIndices[randomIndex];

            _words[selectedWordIndex].Hide();
            visibleIndices.RemoveAt(randomIndex);
        }
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();

        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        return $"{_reference.GetDisplayText()} - {string.Join(" ", displayWords)}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}