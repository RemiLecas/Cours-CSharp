using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JeuxDame;

namespace JeuxDame
{
    public class Move : Piece
    {
        private int targetX;
        private int targetY;
        private int destinationX;
        private int destinationY;
        private bool yourTurn = false;

        public int nbCostJ1 = 0;
        public int nbCostJ2 = 0;

        public Move()
        {
            targetX = 0;
            targetY = 0;
            destinationX = 0;
            destinationY = 0;
            Exit = false;
        }

        public bool Exit { get; set; }

        public void makeMove()
        {
            getInput();

            if (!Exit)
            {
                rearangePieces();
            }
        }

        public void getInput()
        {

            Console.WriteLine("Cost Number J1 : " + nbCostJ1);
            Console.WriteLine("Cost Number J2 : " + nbCostJ2);
            Console.WriteLine();

            if (!yourTurn)
            {
                Console.WriteLine("Player 1 (pieces with 'X') : ");
                yourTurn = true;
            }
            else
            {
                Console.WriteLine("Player 2 (pieces with 'O') :");
                yourTurn = false;
            }


            Console.WriteLine("Enter X axis target");
            Exit = validInput(int.TryParse(Console.ReadLine(), out targetX));

            if (!Exit)
            {
                Console.WriteLine("Enter Y axis target");
                Exit = validInput(int.TryParse(Console.ReadLine(), out targetY));
            }
                           
            if (!Exit)
            {
                Console.WriteLine("Enter X axis target you go");
                Exit = validInput(int.TryParse(Console.ReadLine(), out destinationX));
            }
            if (!Exit)
            {
                Console.WriteLine("Enter Y axis target you go");
                Exit = validInput(int.TryParse(Console.ReadLine(), out destinationY));
            }
        }

        public bool validInput(bool parsed)
        {
            bool error = false;

            if (!parsed)
            {
                error = true;
            }else if (targetX < 0 || targetY < 0 || destinationX < 0 || destinationY < 0)
            {
                error = true;
            }else if (targetX >Board.dimension - 1 || targetY > Board.dimension - 1 || destinationX > Board.dimension - 1 || destinationY > Board.dimension - 1)
            {
                error = true;
            }

            if (error)
            {
                Console.WriteLine("Error detected : Input invalid");
            }

            return error;
        }

        private void rearangePieces()
        {


            if (yourTurn)
            {
                pieces[destinationX, destinationY] = pieces[targetX, targetY];
                pieces[targetX, targetY] = SPACE;
                viewMove();
                nbCostJ1++;

            }
            else if (!yourTurn)
            {
                pieces[destinationX, destinationY] = pieces[targetX, targetY];
                pieces[targetX, targetY] = SPACE;
                nbCostJ2++;
            }
            else
            {
                pieces[targetX, targetY] = SPACE;
            }

        }

        private void viewMove()
        {
            Console.BackgroundColor = ConsoleColor.White;
        }

    }
}
