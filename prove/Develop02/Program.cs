using System;

class Program  // Ensure only one class has Main()
{
    public void Run()
    {
        Journal journal = new Journal();
        PromptMan promptMan = new PromptMan();
        Menu menu = new Menu(journal, promptMan);
        menu.DisplayMenu();
    }

    static void Main()
    {
        Program program = new Program();
        program.Run();
    }
}