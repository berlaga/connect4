using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] connect4 = new int[6, 7] { {0,0,0,0,0,0,0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 } };

            bool keepPlaying = true;
            int order = 1; //blue = 2, red = 1

            Console.WriteLine("Initial state..");
            PrintMatrix(connect4);

            bool skip = false;

            while(keepPlaying)
            {
                Console.WriteLine("");
                Console.WriteLine("");

                
                Console.WriteLine("Drop {0} chip to column?", order == 1? "red" : "blue");


                int column = int.Parse(Console.ReadLine());

                if(PopulateColumn(ref connect4, column, order))
                {
                    Console.WriteLine(string.Format("\t{1} chip added to column {0}", column, order == 1? "RED" : "BLUE"));
                    Console.WriteLine(string.Format(""));

                    order = SwitchTurn(order);
                }
                else
                {
                    Console.WriteLine(string.Format("\tSorry, column {0} is full?", column ));

                }

                PrintMatrix(connect4);
            }

            Console.Read();

        }

        private static int SwitchTurn(int turn)
        {
            if (turn == 1)
            {
                turn++;
            }
            else
            {
                turn--;
            }

            return turn;
        }


        private static bool PopulateColumn(ref int [,] matrix, int columNumber, int chip)
        {
            bool success = false;

            for (int i = 5; i >= 0; i--)
            {
                if(matrix[i, columNumber - 1] == 0)
                {
                    matrix[i, columNumber - 1] = chip;
                    success = true;
                    return success;
                }
            }

            return success;

        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < 6; i++)
            {

                for (int j = 0; j < 7; j++)
                {

                    Console.Write("\t" + matrix[i,j]);

                }

                Console.WriteLine("");


            }
        }
    }
}
