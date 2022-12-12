using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Program
    {
        enum LesJoursDeLaSemaine
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }

        static void Main(string[] args)
        {
            Console.WriteLine("----------- Short en Bytes ----------");
            short s = 300;
            byte b = (byte)s;
            Console.WriteLine(b);

            /* Ici on obtient 44 car dès que l'on dépasse les 255 (car c'est en entier 8 bits) le comptage recommence à 0. */

            Console.WriteLine("----------- Enums ----------");

            LesJoursDeLaSemaine Weekend = LesJoursDeLaSemaine.Samedi | LesJoursDeLaSemaine.Dimanche;

            Console.WriteLine(Weekend);

            Console.WriteLine("----------- Tableau Multidimensionnel ----------");
            int[][] Tableau = new int[3][];
            Tableau[0] = new int[] { 45, 2 };
            Tableau[1] = new int[] { 324, 34, 4, 67 };


            for (int i = 0; i < Tableau.Length - 1; i++)
            {
                for (int j = 0; j < Tableau[i].Length; j++)
                {
                    Console.WriteLine(Tableau[i][j]);
                }
            }

            Console.ReadKey();
        }
    }
}