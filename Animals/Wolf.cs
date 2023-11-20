namespace WorldProject.Animals;

internal class Wolf : Animal
{

    public Wolf(int x, int y) : base(x, y)
    {
        Power = 15;
        Init = 5;
    }

    public override void Collision(Organism organism)
    {

        if (organism is Wolf wolfNext && !IsBorn(wolfNext, this))
        {
            this.isBorn = true;
            wolfNext.isBorn = true;

            int xR = Random.Shared.Next(-1, 2);
            int yR = Random.Shared.Next(-1, 2);

            Wolf wolf = new Wolf(this.X + xR, this.Y + yR);

            world.AddOrganism(wolf);

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

    public override void Draw()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write('W');
        Console.ResetColor();
    }

}
