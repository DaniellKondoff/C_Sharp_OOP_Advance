using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IManager
{
    string Quit(object argsList);
    string AddRecipe(IList<string> args);
    string AddItem(IList<string> args);
    string Inspect(IList<string> args);
    string AddHero(IList<string> args);
}

