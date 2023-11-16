namespace WorldProject.Plants;

internal class Kosylya : Plant
{
    public Kosylya(int x, int y) : base(x, y)
    {
    }

    public override void Action(World world)
    {

        for (int i = 0; i < 3; i++)
        {
            int probability = Random.Shared.Next(1, 4);

            int xR = Random.Shared.Next(-1, 1);
            int yR = Random.Shared.Next(-1, 1);

            if (probability == 1)
            {
                Kosylya k = new Kosylya(X + xR, Y + yR);
                world.AddOrganism(this);
            }

        }
    }

    public override void Collision(Organism organism)
    {
        throw new NotImplementedException();
    }

    public override void Draw()
    {
        Console.WriteLine('K');
    }
}
