using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.WriteLine(reference.ToString());
        foreach (var word in words)
        {
            Console.Write($"{word} ");
        }
        Console.WriteLine();
    }

    public void HideWords(int count)
    {
        var random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < count)
        {
            int index = random.Next(words.Count);
            if (!words[index].ToString().Contains('_'))
            {
                words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public bool IsFullyHidden()
    {
        foreach (var word in words)
        {
            if (!word.ToString().Contains('_'))
                return false;
        }
        return true;
    }
}
