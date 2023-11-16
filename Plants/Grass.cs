namespace WorldProject.Plants;

internal class Grass : Plant
{
    public Grass(int x, int y) : base(x, y)
    {
    }
    protected override Plant CreateClone(int x, int y)
    {
        return new Grass(x, y);
    }
    

    public override void Draw()
    {
        Console.Write('G');
    }

}
