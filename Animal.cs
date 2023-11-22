namespace WorldProject;

internal abstract class Animal : Organism
{
    public int prevX;
    public int prevY;

    public bool isBorn = false;
    public Animal(int x, int y) : base(x, y)
    {
    }

    public override bool Action(World world)
    {
        prevX = this.X;
        prevY = this.Y;

        this.world = world;

        world.ClearOrganism(this.X, this.Y);

        int mRX = Random.Shared.Next(-1, 2);
        int mRY = Random.Shared.Next(-1, 2);

        this.X += (world.IsValid_X(X + mRX)) ? mRX : -mRX;
        this.Y += (world.IsValid_Y(Y + mRY)) ? mRY : -mRY;

        world.AddOrganism(this);

        return true;
    }

    protected bool IsBorn(Animal animal_F, Animal animal_M)
    {
        return animal_F.isBorn && animal_M.isBorn;        
    }

}
