namespace WorldProject.Plants;

internal class Kosylya : Plant
{
    public Kosylya(int x, int y) : base(x, y)
    {
    }
    protected override Plant CreateClone(int x, int y)
    {
        return new Kosylya(x, y);
    }

    public override void Action(World world)
    {

        for (int i = 0; i < 3; i++)
        {
            base.Action(world); 
        }
    }

    public override void Collision(Organism organism)
    {
       
    }

    public override void Draw()
    {
        Console.Write('K');
    }


}
