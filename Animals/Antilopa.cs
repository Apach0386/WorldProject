namespace WorldProject.Animals;

internal class Antilopa : Animal
{
    public Antilopa(int x, int y) : base(x, y)
    {
        Power = 4;
        Init = 4;
    }

    public override bool Action(World world)
    {
        this.world = world;

        int[] array = { -2, 0, 2 };
        int indexX = Random.Shared.Next(0, 3);
        int indexY = Random.Shared.Next(0, 3);

        int mRX = array[indexX];
        int mRY = array[indexY];

        int chekX = this.X + ((world.IsValid_X(X + mRX)) ? mRX : -mRX);
        int chekY = this.Y + ((world.IsValid_Y(Y + mRY)) ? mRY : -mRY);

        if (chekY == -1) //!!
        {
            chekY = 1;
        }

        if (chekX == -1) //!!
        {
            chekX = 1;
        }

        Organism organism = world.GetOrganism(chekX, chekY);
        if (organism != null)
        {
            if (this.Power < organism.Power)
            {
                return false;
            }

            //if (organism is Animal && organism.Power < this.Power)
            //{
            organism.IsLife = false;
            //}
        }

        return true;
    }

    public override void Collision(Organism organism)
    {
        int indexAttac = Random.Shared.Next(0, 100);

        if (indexAttac <= 50)
        {
            this.Action(world); //!!
        }
    }

    public override void Draw()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write('A');
        Console.ResetColor();
    }
}
