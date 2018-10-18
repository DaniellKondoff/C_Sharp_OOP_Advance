using System;
using System.Text;


namespace Last_Army
{
    class LastArmyMain
    {
        static void Main()
        {
            //var input = ConsoleReader.ReadLine();
            //var gameController = new GameController();
            //var result = new StringBuilder();

            //while (!input.Equals("Enough! Pull back!"))
            //{
            //    try
            //    {
            //        gameController.GiveInputToGameController(input);
            //    }
            //    catch (ArgumentException arg)
            //    {
            //        result.AppendLine(arg.Message);
            //    }
            //    input = ConsoleReader.ReadLine();
            //}

            //gameController.RequestResult(result);
            //ConsoleWriter.WriteLine(result.ToString());
            IInputReader reader = new ConsoleReader();
            IOutputWriter writer = new ConsoleWriter();
            Output output = new Output();
            IArmy army = new Army();
            IWareHouse wareHouse = new WareHouse();
            MissionController missionController = new MissionController(army,wareHouse);
            GameController gameController = new GameController(missionController,output);
            Engine engine = new Engine(reader, writer, gameController);
        }
    }
}