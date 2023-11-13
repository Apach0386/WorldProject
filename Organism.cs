namespace WorldProject;

internal abstract class Organism
{
    public int Power { get; set; } = 0;
    public int Init { get; set; } = 0;

    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;

    public abstract void Action();

    public abstract void Collision();

    public abstract void Draw();

}
