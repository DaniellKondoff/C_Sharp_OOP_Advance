using _02.KingsGambit.Model;
using System;
using System.Collections.Generic;
using System.Linq;


public class StartUp
{
    public static void Main(string[] args)
    {
        List<Soldier> army = new List<Soldier>();

        string input = Console.ReadLine();
        King king = new King(input);

        string[] royalGuards = Console.ReadLine().Split();
        foreach (var royalGuard in royalGuards)
        {
            RoyalGuard guard = new RoyalGuard(royalGuard);
            army.Add(guard);
            king.UnderAttack += guard.KingUnderAttack;
        }

        string[] footMen = Console.ReadLine().Split();
        foreach (var footMan in footMen)
        {
            Footman foot = new Footman(footMan);
            army.Add(foot);
            king.UnderAttack += foot.KingUnderAttack;
        }

        string[] command = Console.ReadLine().Split();

        while (command[0] != "End")
        {
            switch (command[0])
            {
                case "Kill":
                    Soldier soldier = army.FirstOrDefault(s => s.Name == command[1]);
                    king.UnderAttack -= soldier.KingUnderAttack;
                    army.Remove(soldier);
                    break;
                case "Attack":
                    king.OnUnderAttack();
                    break;

            }

            command = Console.ReadLine().Split();
        }
    }
}

