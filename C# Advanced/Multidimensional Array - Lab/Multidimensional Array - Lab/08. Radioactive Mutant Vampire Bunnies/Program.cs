using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RadioactiveMutanVampireBunnies
{
    static void Main(string[] args)
    {
        string[] boardSize = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int boardHeight = int.Parse(boardSize[0]);
        int boardWidth = int.Parse(boardSize[1]);
        var board = new char[boardHeight][];

        int startingHeight = 0;
        int startingWidth = 0;

        for (int x = 0; x < boardHeight; x++)
        {
            board[x] = Console.ReadLine().ToCharArray();

            if (board[x].Contains('P'))
            {
                startingHeight = x;

                for (int i = 0; i < board[x].Length; i++)
                {
                    if (board[x][i] == 'P')
                    {
                        startingWidth = i;
                        break;
                    }
                }
            }
        }

        string commands = Console.ReadLine();


        int currentHeight = startingHeight;
        int currentWidth = startingWidth;

        bool isDead = false;

        for (int i = 0; i < commands.Length; i++)
        {

            if (commands[i] == 'U')
            {
                try
                {
                    board[currentHeight][currentWidth] = '.';
                    board[currentHeight - 1][currentWidth] = 'P';
                }
                catch (Exception)
                {
                    Mutate(boardHeight, boardWidth, board);
                    break;
                }


                currentHeight--;
            }
            else if (commands[i] == 'D')
            {
                try
                {
                    board[currentHeight][currentWidth] = '.';
                    board[currentHeight + 1][currentWidth] = 'P';
                }
                catch (Exception)
                {
                    Mutate(boardHeight, boardWidth, board);
                    break;
                }


                currentHeight++;
            }
            else if (commands[i] == 'L')
            {
                try
                {
                    board[currentHeight][currentWidth] = '.';
                    board[currentHeight][currentWidth - 1] = 'P';
                }
                catch (Exception)
                {
                    Mutate(boardHeight, boardWidth, board);
                    break;
                }

                currentWidth--;
            }
            else if (commands[i] == 'R')
            {
                try
                {
                    board[currentHeight][currentWidth] = '.';
                    board[currentHeight][currentWidth + 1] = 'P';
                }
                catch (Exception)
                {
                    Mutate(boardHeight, boardWidth, board);
                    break;
                }


                currentWidth++;
            }

            Mutate(boardHeight, boardWidth, board);

            bool contains = false;
            for (int k = 0; k < boardHeight; k++)
            {
                if (board[k].Contains('P'))
                {
                    contains = true;
                    break;
                }
            }

            if (!contains)
            {
                isDead = true;
                break;
            }
        }

        PrintBoardState(boardHeight, board);

        if (isDead)
        {
            Console.WriteLine($"dead: {currentHeight} {currentWidth}");
        }
        else
        {
            Console.WriteLine($"won: {currentHeight} {currentWidth}");
        }

    }

    public static void PrintBoardState(int boardHeight, char[][] board)
    {
        for (int x = 0; x < boardHeight; x++)
        {
            Console.WriteLine(string.Join("", board[x]));
        }
    }

    public static void Mutate(int boardHeight, int boardWidth, char[][] board)
    {
        var bunniesX = new Queue<int>();
        var bunniesY = new Queue<int>();

        int bunniesCounter = 0;

        for (int x = 0; x < boardHeight; x++)
        {
            for (int y = 0; y < boardWidth; y++)
            {
                if (board[x][y] == 'B')
                {
                    bunniesX.Enqueue(x);
                    bunniesY.Enqueue(y);

                    bunniesCounter++;
                }
            }
        }

        for (int i = 0; i < bunniesCounter; i++)
        {
            int currentBunnieX = bunniesX.Dequeue();
            int currentBunnieY = bunniesY.Dequeue();

            try
            {
                board[currentBunnieX - 1][currentBunnieY] = 'B';

            }
            catch (Exception)
            {
            }

            try
            {
                board[currentBunnieX + 1][currentBunnieY] = 'B';

            }
            catch (Exception)
            {
            }

            try
            {
                board[currentBunnieX][currentBunnieY - 1] = 'B';

            }
            catch (Exception)
            {
            }

            try
            {
                board[currentBunnieX][currentBunnieY + 1] = 'B';

            }
            catch (Exception)
            {
            }
        }
    }
}