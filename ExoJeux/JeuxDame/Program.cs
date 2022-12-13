
using JeuxDame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoJeux
{
    class Program
    {
        static void Main(string[] args)
        {
            string player;

            Console.WriteLine("Do you want to play this game ? Y = Yes / N = No");
            player = Console.ReadLine();

            if(player == "Yes" || player == "Y" || player == "Ye" || player == "yes" || player == "y" || player == "ye")
            {
                // show board

                Board board = new Board();
                board.displayBoard();
            }


            Console.Clear();
        }

    }
}
