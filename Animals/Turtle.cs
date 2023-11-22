namespace WorldProject.Animals;

internal class Turtle : Animal
{
    public Turtle(int x, int y) : base(x, y)
    {
        Power = 2;
        Init = 1;
    }

    public override bool Action(World world)
    {
        int probability = Random.Shared.Next(0, 100);

        if (probability < 75)
        {
            return false;
        }
        base.Action(world);
        return true;
    }

    public override void Collision(Organism organism)
    {       

        if (organism is Turtle turtleNext && !IsBorn(turtleNext, this))
        {
            this.isBorn = true;
            turtleNext.isBorn = true;

            int xR = Random.Shared.Next(-1, 2);
            int yR = Random.Shared.Next(-1, 2);

            Turtle turtle = new Turtle(this.X + xR, this.Y + yR);

            world.AddOrganism(turtle);

            int xRo = Random.Shared.Next(-1, 2);
            int yRo = Random.Shared.Next(-1, 2);

            organism.X = xRo;
            organism.Y = yRo;

            world.AddOrganism(organism);

            return;
        }

        if (organism is Animal animal && organism.Power < 5)
        {
            organism.X = animal.prevX;
            organism.Y = animal.prevY;

            world.AddOrganism(organism);

            return;
        }

    }

    public override void Draw()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write('T');
        Console.ResetColor();
    }
}
