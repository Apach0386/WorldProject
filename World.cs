﻿namespace WorldProject;

internal class World
{
    private int width = 0;
    private int height = 0;

    Organism[,] board;
    public World(int width, int height)
    {
        this.width = width;
        this.height = height;
        board = new Organism[height, width];
    }
    public void ExecuteTure()
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                board[i, j]?.Action(this);
            }
        }
    }

    public void DrawWorld()
    {
        Console.WriteLine(new string('-', width + 2));
        for (int i = 0; i < board.GetLength(0); i++)
        {
            Console.Write("|");
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[i, j] != null)
                {
                    board[i, j].Draw();
                }
                else
                {
                    Console.Write(" ");
                }

            }
            Console.Write("|");
            Console.WriteLine();
        }
        Console.WriteLine(new string('-', width + 2));

    }

    public void AddOrganism(Organism organism)
    {
        board[organism.Y, organism.X] = organism;
    }
}
