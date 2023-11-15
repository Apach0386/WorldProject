namespace WorldProject.Plants;

internal class Grass : Plant
{
    public Grass(int x, int y) : base(x, y)
    {
    }

    public override void Action(World world)
    {
        int xR = Random.Shared.Next(-1, 1);
        int yR = Random.Shared.Next(-1, 1);

        Grass g = new Grass(X + xR, Y + yR);

        world.AddOrganism(g);
    }

    public override void Collision()
    {
        throw new NotImplementedException();
    }

    public override void Draw()
    {
        Console.Write('G');
    }
}
