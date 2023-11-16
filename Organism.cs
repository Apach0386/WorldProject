﻿namespace WorldProject;

internal abstract class Organism
{
    public int Power { get; set; } = 0;
    public int Init { get; set; } = 0;

    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;

    public Organism(int x, int y)
    {
        X = x;
        Y = y;
    }

    public abstract void Action(World world);

    public abstract void Collision(Organism organism);

    public abstract void Draw();

}
