using System;


public class ConsoleWriter : IOutputWriter
{
    public void WriteLine(string output)
    {
        Console.WriteLine(output);
    }
}
