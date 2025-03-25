using System; 

public class Person
{
    public string ID { get; set; }
    public string Name { get; set; }
    public string Type { get; set; } // Add Type property

    public Person(string id, string name, string type)
    {
        ID = id;
        Name = name;
        Type = type;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Type: {Type}"); // Display Type
    }
}