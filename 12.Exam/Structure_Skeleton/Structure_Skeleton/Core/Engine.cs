using System;
using System.Collections.Generic;
using System.Linq;

public class Engine : IEngine
{
    private IDraftManager manager;
    private IReader reader;
    private IWriter writer;
    private ICommandInterpreter commandIntepreter;

    public Engine(IDraftManager draftManager, IReader reader, IWriter writer, ICommandInterpreter commandIntepreter)
    {
        this.manager = draftManager;
        this.reader = reader;
        this.writer = writer;
        this.commandIntepreter = commandIntepreter;
    }

    public void Run()
    {
        while (true)
        {
            var input = reader.ReadLine();
            var data = input.Split().ToList();
            string result = this.commandIntepreter.ProcessCommand(data);
            this.writer.WriteLine(result);
            //var command = data[0];
            //switch (command)
            //{
            //    
            //    case "Day":
            //        manager.Day();
            //        break;
            //    case "Mode":
            //        args = new List<string>(data.Skip(1).ToList());
            //        manager.Mode(args);
            //        break;
            //    case "Check":
            //        args = new List<string>(data.Skip(1).ToList());
            //        //Console.WriteLine(manager.Check(args));
            //        writer.WriteLine(manager.Check(args));
            //        break;
            //}
        }
    }
}
