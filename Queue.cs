using System;
using System.Collections.Generic;
using System.Linq;

namespace Queue
{

    public class Game_File
    {

        public string Selection(int Gamemode)
        {
            string Gamevalue = "0";
            switch (Gamemode) 
            {
                case 1:
                    Gamevalue = "You have chosen a new game";
                    break;

                case 2:
                    Gamevalue = "You have chosen another game, thus the first game will be closed";
                    break;

                case 3:
                    Gamevalue = "The game is running";
                    break;

                case 4:
                    Gamevalue = "The game is reading you're safe file";
                    break;

                case 5:
                    Gamevalue = "The game is being closed";
                    break;
            }
            return Gamevalue;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> GameCatagory = new Queue<string>();
            bool Gamelist;
            Gamelist = true;
            while (Gamelist)
            {
                Console.Clear();
                Console.WriteLine("1, Insert game");
                Console.WriteLine("2, Show number of games");
                Console.WriteLine("3, Remove game");
                Console.WriteLine("4, Show number of games running");
                Console.WriteLine("5, Close");


                Game_File choose = new Game_File();
                string result = choose.Selection(int.Parse(Console.ReadLine()));
                Console.WriteLine(result);

                if (result == "You have chosen a game")
                {
                    Gamelist = true;
                }



                else if (result == "The game is being opened")
                {
                    Console.WriteLine("Game's Name: ");
                    string Game = Console.ReadLine();
                    GameCatagory.Enqueue(Game);
                    Console.ReadLine();
                }
                else if (result == "You have chosen another game, thus the first game will be closed")
                {
                    GameCatagory.Dequeue();
                    Console.ReadLine();
                }
                else if (result == "Reading last safe file")
                {
                    Console.WriteLine($"Games in libary: {GameCatagory.Count}");
                    Console.ReadLine();
                }
              
            }
        }
    }
}
