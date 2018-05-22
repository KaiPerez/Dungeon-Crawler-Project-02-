using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Program
    {

        static void PrintBoard(string[][] board)
        {
            for (int i = 0; i < board.Length; i++) // go through every row
            {
                for (int j = 0; j < board[i].Length; j++) // go through every column
                {
                    // Use Write instead of WriteLine so the whole row is on one line
                    Console.Write(board[i][j]); // find the current cell using row/column
                }
                // Print a new line so every row is on a different line
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            string[][] board = new string[][]
            {
                new string[] { "#", "#", "#", "#", "#" },
                new string[] { "#", ".", ".", ".", "#" }, // first row
                new string[] { "#", ".", "V", ".", "#" }, // second row
                new string[] { "#", ".", ".", ".", "#" }, // third row
                new string[] { "#", "#", "#", "#", "#" },
            };
 
            PrintBoard(board);
        
            Console.WriteLine("Enter a direction.");
            
            string direction = Console.ReadLine();
            

            Console.ReadKey();
           





        }
    }
}

