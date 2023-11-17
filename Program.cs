using WorldProject;
using WorldProject.Plants;

World w = new World(40,20);
w.DrawWorld();
w.AddOrganism(new Grass(5, 5));
w.AddOrganism(new Kosylya(8, 7));
w.AddOrganism(new Guarana(7, 8));
w.AddOrganism(new WolfBerries(1,1));
while (true)
{
    w.ExecuteTure();
    w.DrawWorld();
    Thread.Sleep(1000);
    Console.Clear();
}