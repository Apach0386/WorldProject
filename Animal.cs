namespace WorldProject;

internal abstract class Animal : Organism
{
    public Animal(int x, int y) : base(x, y)
    {
    }

    public override void Action(World world)
    {
        throw new NotImplementedException();
    }

    public override void Collision()
    {
        throw new NotImplementedException();
    }

    public override void Draw()
    {
        throw new NotImplementedException();
    }
}
