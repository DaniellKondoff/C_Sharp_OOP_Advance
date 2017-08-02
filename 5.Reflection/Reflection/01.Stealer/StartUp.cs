using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StartUp
{
    static void Main(string[] args)
    {
        Spy spy = new Spy();
        //string result = spy.StealFieldInfo("Hacker", "username", "password");
        string result = spy.CollectGettersAndSetters("Hacker");
        Console.WriteLine(result);
    }
}

