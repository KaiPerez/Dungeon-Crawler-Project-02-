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
            int x = 2;
            int y = 2;
          
            Console.WriteLine("Enter a direction To Move");
            Console.WriteLine("(Up, Down, Left, Right)");
            Console.WriteLine("Enter 'Exit' to leave the program.");
            string Direction = "Nothing";
            while (Direction != "Exit") {
                Console.WriteLine("Enter a Direction");
                Direction = Console.ReadLine();
                if (Direction == "Up" || Direction == "up")
                {
                    if (board[y - 1][x] == ".")
                    {

                        board[y][x] = ".";
                        y = y - 1;
                        board[y][x] = "V";
                        PrintBoard(board);
                    }
                    else
                    {
                        Console.WriteLine("Can't go there!");
                    }
                } else if (Direction == "Down" || Direction == "down")
                {
                    if (board[y + 1][x] == ".")
                    {

                        board[y][x] = ".";
                        y = y + 1;
                        board[y][x] = "V";
                        PrintBoard(board);
                    }
                    else
                    {
                        Console.WriteLine("Can't go there!");
                    }
                }
                else if (Direction == "Right" || Direction == "right")
                {
                    if (board[y][x + 1] == ".")
                    {

                        board[y][x] = ".";
                        x = x + 1;
                        board[y][x] = "V";
                        PrintBoard(board);
                    }
                    else
                    {
                        Console.WriteLine("Can't go there!");
                    }
                }
                else if (Direction == "Left" || Direction == "left")
                {
                    if (board[y][x - 1] == ".")
                    {

                        board[y][x] = ".";
                        x = x - 1;
                        board[y][x] = "V";
                        PrintBoard(board);
                    }
                    else
                    {
                        Console.WriteLine("Can't go there!");
                    }
                }
            }

            Console.ReadKey();
           





        }
    }
}

