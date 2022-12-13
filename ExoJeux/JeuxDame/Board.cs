using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxDame
{
    public class Board
    {
        
        private string[,] myBoard;
        public const int dimension = 8; 

        private Move move;
        public string BoardHorizontalSymbol { get; set; }
        public string BoardVerticalSymbol { get; set; }
        
        public void displayBoard()
        {
            while (!move.Exit)
            {
                Console.Clear();
                Console.WriteLine("    0    1     2    3    4    5    6    7");

                for(int r=0; r<dimension; r++)
                {
                    Console.Write("  ");
                    for(int c= 0; c<dimension; c++)
                    {
                        Console.Write(BoardHorizontalSymbol);
                    }

                    Console.Write("+\n");

                    for(int c = 0; c<dimension; c++)
                    {
                        if(c == 0)
                        {
                            Console.Write(r + " ");
                        }
                        Console.Write(BoardVerticalSymbol + Piece.pieces[r,c] + " ");

                    }
                    Console.Write("|\n");
                }
                //bottom part
                Console.Write("  ");
                for(int c=0; c<dimension; c++)
                {
                    Console.Write(BoardHorizontalSymbol);
                }
                Console.Write("+\n\n");
                move.makeMove();
            }

        }
        public Board(){
            move = new Move();
            myBoard = new string[dimension, dimension];
            BoardHorizontalSymbol = "+----";
            BoardVerticalSymbol = "|  ";

        }


         

    }
}
