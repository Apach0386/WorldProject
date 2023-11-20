namespace WorldProject;

internal abstract class Organism
{
    protected World world;

    public bool IsLife { get; set; } = true;

    public int Power { get; set; } = 0;
    public int Init { get; set; } = 0;

    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;

    public Organism(int x, int y)
    {
        X = x;
        Y = y;
    }

    public abstract bool Action(World world);

    public abstract void Collision(Organism organism);

    public abstract void Draw();

    public void SetWorld(World world)
    {
        this.world = world;
    }

}
