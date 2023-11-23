namespace WorldProject;

internal class World
{
    private int width = 0;
    private int height = 0;

    //private int countOrganism = 0;


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
                if (board[i,j] is Animal animal)
                {
                    animal.isBorn = false;
                }
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
        organism.SetWorld(this);

        if (!IsValid_Y(organism.Y) || !IsValid_X(organism.X))
        {
            return;
        }

        if (board[organism.Y, organism.X] == null)
        {
            board[organism.Y, organism.X] = organism;

            //countOrganism++;

            return;
        }

        Organism boardOrganism = board[organism.Y, organism.X];
        InitAttac(organism, boardOrganism);

        if (organism.X != boardOrganism.X || organism.Y != boardOrganism.Y)
        {
            return;
        }

        if (organism.IsLife && boardOrganism.IsLife)
        {
            InitAttacSecond(organism, boardOrganism);
        }

        if (organism.X != boardOrganism.X || organism.Y != boardOrganism.Y)
        {
            return;
        }

        if (boardOrganism.IsLife && organism.IsLife && IsValid_X(organism.X) && IsValid_Y(organism.Y))
        {
            board[organism.Y, organism.X] = organism;
        }

        //countOrganism++;
    }
    public void ClearOrganism(int x, int y)
    {
        if (IsValid_X(x) && IsValid_Y(y))
        {
            board[y, x] = null;
        }
    }

    public bool IsValid_X(int x) => (x >= 0 && x < width);

    public bool IsValid_Y(int y) => (y >= 0 && y < height);

    public Organism GetOrganism(int x, int y)
    {
         return board[y, x]; 
    }

    public void InitAttac(Organism organism_0, Organism organism_1)
    {
        if (organism_0.Init > organism_1.Init)
        {
            organism_0.Collision(organism_1);
        }
        else
        {
            organism_1.Collision(organism_0);
        }
    }

    public void InitAttacSecond(Organism organism_0, Organism organism_1)
    {
        if (organism_0.Init > organism_1.Init)
        {
            organism_1.Collision(organism_0);
        }
        else
        {
            organism_0.Collision(organism_1);
        }
    }
        

}
