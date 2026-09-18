using System;
using System.Collections.Generic;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _random;

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();
        _random = new Random();
    }

    public void AddScripture(Scripture scripture)
    {
        if (scripture != null)
        {
            _scriptures.Add(scripture);
        }
    }

    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0)
        {
            return null;
        }

        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}