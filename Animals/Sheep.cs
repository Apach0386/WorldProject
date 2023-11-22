namespace WorldProject.Animals;

internal class Sheep : Animal
{
    public Sheep(int x, int y) : base(x, y)
    {
        Power = 1;
        Init = 4;
    }

    public override void Collision(Organism organism)
    {
        if (organism is Sheep sheepNext && !IsBorn(sheepNext, this))
        {
            this.isBorn = true;
            sheepNext.isBorn = true;

            int xR = Random.Shared.Next(-1, 2);
            int yR = Random.Shared.Next(-1, 2);

            Sheep sheep = new Sheep(this.X + xR, this.Y + yR);

            world.AddOrganism(sheep);

            int xRo = Random.Shared.Next(-1, 2);
            int yRo = Random.Shared.Next(-1, 2);

            organism.X = xRo;
            organism.Y = yRo;

            world.AddOrganism(organism);

        }
            if (organism is Animal && organism.Power > this.Power)
            {
                this.IsLife = false;
            }
    }

    public override void Draw()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write('S');
        Console.ResetColor();
    }
}
