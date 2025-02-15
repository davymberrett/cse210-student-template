class Scripture
{
    private Reference Reference { get; }
    private List<Word> Words { get; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            Words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count = 3)
    {
        var rnd = new Random();
        var visibleWords = Words.FindAll(word => !word.Hidden);

        if (visibleWords.Count <= count)
        {
            foreach (var word in visibleWords)
            {
                word.Hide();
            }
        }
        else
        {
            for (int i = 0; i < count; i++)
            {
                var wordToHide = visibleWords[rnd.Next(visibleWords.Count)];
                wordToHide.Hide();
                visibleWords.Remove(wordToHide);
            }
        }
    }

    public bool AllHidden()
    {
        return Words.TrueForAll(word => word.Hidden);
    }

    public override string ToString()
    {
        return $"{Reference}\n" + string.Join(" ", Words);
    }
}
