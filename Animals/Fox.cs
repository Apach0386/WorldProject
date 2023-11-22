namespace WorldProject.Animals;

internal class Fox : Animal
{
    public Fox(int x, int y) : base(x, y)
    {
        Power = 3;
        Init = 7;
    }

    public override void Collision(Organism organism)
    {

        if (organism is Fox foxNext && !IsBorn(foxNext, this))
        {
            this.isBorn = true;
            foxNext.isBorn = true;

            int xR = Random.Shared.Next(-1, 2);
            int yR = Random.Shared.Next(-1, 2);

            Fox fox = new Fox(this.X + xR, this.Y + yR);

            world.AddOrganism(fox);

            int xRo = Random.Shared.Next(-1, 2);
            int yRo = Random.Shared.Next(-1, 2);

            organism.X = xRo;
            organism.Y = yRo;

            world.AddOrganism(organism);
        }

        if (organism is Animal && organism.Power < this.Power)
        {
            organism.IsLife = false;
        }
    }

    public override bool Action(World world)
    {

        this.world = world;               

        int mRX = Random.Shared.Next(-1, 2);
        int mRY = Random.Shared.Next(-1, 2);

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

        world.ClearOrganism(this.X, this.Y);

        this.X = chekX;
        this.Y = chekY;

        world.AddOrganism(this);

        return true;
    }

    public override void Draw()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write('F');
        Console.ResetColor();
    }
}
