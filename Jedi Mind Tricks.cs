using System;
using System.Collections.Generic;
using System.Linq;

namespace Jedi_Mind_Tricks
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Maincharacter = new Dictionary<string, int>();
            Maincharacter.Add("Belmont", 30);
            Maincharacter.Add("Alucard", 102);
            Maincharacter.Add("Isacc", 38);
            Maincharacter.Add("Hector", 34);

            Maincharacter["Dracula"] = 500;
            Maincharacter["Dracula's wife"] = 50;

            var Belmont = Maincharacter.First();
            Console.WriteLine(Belmont);

            var Alucard = Maincharacter.First();
            Console.WriteLine(Alucard);

            var Isacc = Maincharacter.First();
            Console.WriteLine(Isacc);

            var Hector = Maincharacter.First();
            Console.WriteLine(Hector);

            Maincharacter.Remove("Dracula's wife");

            foreach (KeyValuePair<string, int> entry in Maincharacter)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    entry.Key, entry.Value);
            }
        }
    }
}