using System;
using System.Linq;
//using System.Collection.Generic;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name:  ");
                var player = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("          Welcome to Battleship, {0}!", player);
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 50)));
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 20)) + "BattleShip" + string.Concat(Enumerable.Repeat("=", 20)));
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 50)));
            Console.WriteLine();
            Console.WriteLine("You have 40 torpedos to try and destroy the 5 enemy ships.");
            Console.WriteLine("There is a Aircraft Carrier, Battleship, Submarine, Crusier, & Destroyer.");
            Console.WriteLine();
            Console.Write("Do you want to start a game? Enter 'Y' to start, or any other key to exit:  ");
                var check = Console.ReadLine();
                var GuessCount = 0;
            while (check == "Y" )
                {
                    Console.WriteLine("pass");
                   // while (true) I got to figure out how to make a map here
                    //{
                      //  BuildMap();
                   // }
                   Console.Write("Do you want to play again? Enter 'Y' to start, or any other key to exit:  ");
                   check = Console.ReadLine();
                }
            
        }

    }
}
