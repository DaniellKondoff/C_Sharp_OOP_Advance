﻿using _08.MilitaryElite.Interfaces;
using _08.MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MilitaryElite
{
    class StartUp
    {
        private static IList<ISoldier> army;
        static void Main()
        {
            string input;
             army = new List<ISoldier>();
            while ((input = Console.ReadLine()) != "End")
            {
                var args = input.Split();
                switch (args[0])
                {
                    case "Private":
                        army.Add(new Private(int.Parse(args[1]), args[2], args[3], double.Parse(args[4])));
                        break;

                    case "Spy":
                        army.Add(new Spy(int.Parse(args[1]), args[2], args[3], int.Parse(args[4])));
                        break;

                    case "LeutenantGeneral":
                        var privates = ExtractPrivates(args.Skip(5).ToList());
                        army.Add(new LeutenantGeneral(int.Parse(args[1]), args[2], args[3], double.Parse(args[4]), privates));
                        break;

                    case "Commando":
                        if (args[5] != "Airforces" && args[5] != "Marines")
                        {
                            break;
                        }
                        var missions = ExtractMissions(args.Skip(6).ToList());
                        army.Add(new Commando(int.Parse(args[1]), args[2], args[3], double.Parse(args[4]), args[5], missions));
                        break;

                    case "Engineer":
                        if (args[5] != "Airforces" && args[5] != "Marines")
                        {
                            break;
                        }
                        var parts = ExtractParts(args.Skip(6).ToList());
                        army.Add(new Engineer(int.Parse(args[1]), args[2], args[3], double.Parse(args[4]), args[5], parts));
                        break;
                }
            }

            foreach (var soldier in army)
            {
                Console.WriteLine(soldier);
            }
        }

        private static IList<IRepair> ExtractParts(IList<string> parts)
        {
            var list = new List<IRepair>();

            for (int i = 0; i < parts.Count - 1; i += 2)
            {
                //VALIDATION
                list.Add(new Repair(int.Parse(parts[i]), int.Parse(parts[i + 1]).ToString()));
            }

            return list;
        }

        private static IList<IMission> ExtractMissions(IList<string> missions)
        {
            var list = new List<IMission>();

            for (int i = 0; i < missions.Count - 1; i += 2)
            {
                if (missions[i + 1] != "inProgress" && missions[i + 1] != "Finished")
                {
                    continue;
                }
                list.Add(new Mission(missions[i], missions[i + 1]));
            }

            return list;
        }

        private static IList<ISoldier> ExtractPrivates(IList<string> soldiers)
        {
            var list = new List<ISoldier>();

            foreach (var soldier in soldiers)
            {
                list.Add(army.First(s => s.Id.ToString() == soldier));
            }

            return list;

        }
    }
}
