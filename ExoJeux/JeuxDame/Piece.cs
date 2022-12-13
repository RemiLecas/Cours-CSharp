using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxDame
{
    public class Piece
    {
        public const char Piece_Symbol_J1 = 'X';
        public const char Piece_Symbol_J2 = 'O';
        public const char SPACE = ' ';

        public static char[,] pieces;

        public Piece()
        {
            pieces = new char[Board.dimension, Board.dimension];

            initPiecesJ2();
        }

        private void initPiecesJ2()
        {
            for (int i = 0; i < Board.dimension; i++)
            {
                for(int j = 0; j < Board.dimension; j++)
                {
                    if(i == 0 || i == 1)
                    {
                        pieces[i, j] = Piece_Symbol_J2;
                    }
                    else
                    {
                        pieces[i, j] = SPACE;
                    }
                }
            }

            initPiecesJ1();
            
        }

        private void initPiecesJ1()
        {
            for (int i = 5; i < Board.dimension; i++)
            {
                for (int j = 0; j < Board.dimension; j++)
                {

                    if (i == Board.dimension - 2 || i == Board.dimension - 1)
                    {
                        pieces[i, j] = Piece_Symbol_J1;
                    }
                    else
                    {
                        pieces[i, j] = SPACE;
                    }
                }
            }
        }

    }
}
