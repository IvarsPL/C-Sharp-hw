using System;
using System.Security.Cryptography.X509Certificates;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            InitBoard();
            DisplayBoard();
            char activePlayer = SelectPlayer();
            while (IsATie() == false && WinningCondition(activePlayer) == false)
            {
                PickTurn();
            }

            Console.ReadKey();
        }

        private static char SelectPlayer()
        {
            char player;
            var xCount = 0;
            var oCount = 0;

            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                {
                    if (board[r, c] == 'X')
                    {
                        xCount++;
                    }
                    else if (board[r, c] == 'O')
                    {
                        oCount++;
                    }
                }
            }

            player = xCount > oCount ? 'O' : 'X';

            return player;
        }

        public static void PickTurn()
        {
            var activePlayer = SelectPlayer();

            Console.Write($"{activePlayer} choose your location (row column): ");
            var input = Console.ReadLine() ?? throw new InvalidOperationException();
            string[] tokens = input.Split(' ');
            int[] numbers = Array.ConvertAll(tokens, int.Parse);
            var row = numbers[0];
            var column = numbers[1];

            if (board[row, column] == ' ')
            {
                board[row, column] = activePlayer;
                DisplayBoard();
                WinningCondition(activePlayer);
            }
            else
            {
                Console.WriteLine("This field is not available");
            }
        }

        private static bool WinningCondition(char player)
        {
            var winningText = $"Player {player} wins";
            if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
            {
                Console.WriteLine(winningText);
                return true;
            }

            if (board[2, 0] == player && board[1, 1] == player && board[0, 2] == player)
            {
                Console.WriteLine(winningText);
                return true;
            }
            if (board[0, 0] == player && board[0, 1] == player && board[0, 2] == player)
            {
                Console.WriteLine(winningText);
                return true;
            }
            if (board[1, 0] == player && board[1, 1] == player && board[1, 2] == player)
            {
                Console.WriteLine(winningText);
                return true;
            }
            if (board[2, 0] == player && board[2, 1] == player && board[2, 2] == player)
            {
                Console.WriteLine(winningText);
                return true;
            }
            if (board[0, 0] == player && board[1, 0] == player && board[2, 0] == player)
            {
                Console.WriteLine(winningText);
                return true;
            }
            if (board[0, 1] == player && board[1, 1] == player && board[2, 1] == player)
            {
                Console.WriteLine(winningText);
                return true;
            }
            if (board[0, 2] == player && board[1, 2] == player && board[2, 2] == player)
            {
                Console.WriteLine(winningText);
                return true;
            }

            return false;
        }

        private static bool IsATie()
        {
            if ((board[0, 0] == 'X' || board[0, 0] == 'O') &&
                (board[0, 1] == 'X' || board[0, 1] == 'O') &&
                (board[0, 2] == 'X' || board[0, 2] == 'O') &&
                (board[1, 0] == 'X' || board[1, 0] == 'O') &&
                (board[1, 1] == 'X' || board[1, 1] == 'O') &&
                (board[1, 2] == 'X' || board[1, 2] == 'O') &&
                (board[2, 0] == 'X' || board[2, 0] == 'O') &&
                (board[2, 1] == 'X' || board[2, 1] == 'O') &&
                (board[2, 2] == 'X' || board[2, 2] == 'O'))
            {
                Console.WriteLine("It's a Tie");
                return true;
            }
            return false;
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }
    }
}
