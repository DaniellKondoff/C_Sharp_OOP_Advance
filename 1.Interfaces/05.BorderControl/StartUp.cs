using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BorderControl
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IList<IBirthday> birthdateLists = new List<IBirthday>();

            var input = Console.ReadLine();
            IBirthday birthdate = null;
            while (input != "End")
            {
                var tokens = input.Split().ToArray();

                if (tokens[0]=="Citizen")
                {
                    birthdate = new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]);
                }
                else
                {
                    birthdate = new Pet(tokens[1], tokens[2]);
                }
                birthdateLists.Add(birthdate);
                input = Console.ReadLine();
            }

            string pattern = Console.ReadLine().Trim();

            var result = birthdateLists.Where(s => s.Birthdate.EndsWith(pattern)).Select(s=>s.Birthdate).ToList();

            if (result.Count==0)
            {
                Console.WriteLine(string.Empty);
            }
            Console.WriteLine(string.Join(Environment.NewLine,result.ToString()));
        }
    }
}
