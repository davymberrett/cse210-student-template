class Reference
{
    private string Book { get; }
    private int Chapter { get; }
    private int StartVerse { get; }
    private int EndVerse { get; }

    public Reference(string book, int chapter, int startVerse, int endVerse = -1)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse == -1 ? startVerse : endVerse;
    }

    public override string ToString()
    {
        if (StartVerse == EndVerse)
            return $"{Book} {Chapter}:{StartVerse}";
        else
            return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
    }
}
