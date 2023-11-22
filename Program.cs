using WorldProject;
using WorldProject.Animals;
using WorldProject.Plants;

World w = new World(10,5);

w.DrawWorld();
//w.AddOrganism(new Grass(5, 5));
//w.AddOrganism(new Kosylya(8, 7));
//w.AddOrganism(new Guarana(7, 8));
//w.AddOrganism(new WolfBerries(1,1));

w.AddOrganism(new Wolf(3,3));
w.AddOrganism(new Wolf(3, 3));

w.AddOrganism(new Sheep(4, 4));
w.AddOrganism(new Sheep(4, 4));


Console.Clear();
Console.CursorVisible= false;

while (true)
{
    w.ExecuteTure();
    w.DrawWorld();
    Thread.Sleep(1000);
    Console.SetCursorPosition(0,0);
}