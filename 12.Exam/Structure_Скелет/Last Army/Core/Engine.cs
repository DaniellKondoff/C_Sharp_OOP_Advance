using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Engine
{
    private const string MessageForQuit = "Enough! Pull back!";
    private IInputReader reader;
    private IOutputWriter writer;
    private GameController gameController;
    private StringBuilder result;
    public Engine(IInputReader reader, IOutputWriter writer, GameController gameController)
    {
        this.reader = reader;
        this.writer = writer;
        this.gameController = gameController;
        this.result = new StringBuilder();
    }
    public void Run()
    {
        bool isRunning = true;

        while (isRunning)
        {
            string inputLine = this.reader.ReadLine();
            this.gameController.GiveInputToGameController(inputLine);
            isRunning = !this.ShouldEnd(inputLine);
        }

        result.Append(this.gameController.RequestResult());
        this.writer.WriteLine(result.ToString());
    }
    private bool ShouldEnd(string inputLine)
    {
        return inputLine.Equals(MessageForQuit);
    }
}

