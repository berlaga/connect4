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
            int order = 1;

            Console.WriteLine("Initial state..");
            PrintMatrix(connect4);

            int chipType = 1;

            while(keepPlaying)
            {
                Console.WriteLine("");
                Console.WriteLine("");

                if (order == 1)
                {
                    Console.WriteLine("Drop blue chip to column?");
                    order++;
                }
                else
                {
                    Console.WriteLine("Drop red chip to column?");
                    order--;
                }

                int column = int.Parse(Console.ReadLine());

                PopulateColumn(ref connect4, column, order);

                chipType++;

                if(chipType % 5 == 0)
                {
                    PrintMatrix(connect4);

                }
            }

            Console.Read();

        }

        private static void PopulateColumn(ref int [,] matrix, int columNumber, int chip)
        {
            for (int i = 5; i >= 0; i--)
            {
                if(matrix[i, columNumber - 1] == 0)
                {
                    matrix[i, columNumber - 1] = chip;
                    break;
                }
            }

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
