public class Major
{
    public string Name { get; set; }
    public List<string> Classes { get; set; }

    public Major(string name)
    {
        Name = name;
        Classes = new List<string>();
    }
}

