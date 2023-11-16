using WorldProject;
using WorldProject.Plants;

World w = new World(20,10);
w.DrawWorld();
w.AddOrganism(new Grass(5, 5));
w.AddOrganism(new Kosylya(8, 7));
while (true)
{
    w.ExecuteTure();
    w.DrawWorld();
    Thread.Sleep(1000);
    Console.Clear();
}