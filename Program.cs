using WorldProject;
using WorldProject.Animals;
using WorldProject.Plants;

World w = new World(40,20);

w.DrawWorld();
w.AddOrganism(new Grass(6, 6));
w.AddOrganism(new Kosylya(8, 7));
w.AddOrganism(new Guarana(7, 8));
w.AddOrganism(new WolfBerries(10, 19));

w.AddOrganism(new Wolf(11, 11));
w.AddOrganism(new Wolf(11, 11));


w.AddOrganism(new Turtle(14, 14));
w.AddOrganism(new Turtle(14, 14));


w.AddOrganism(new Fox(13, 13));
w.AddOrganism(new Fox(13, 13));




Console.Clear();
Console.CursorVisible= false;

while (true)
{
    w.ExecuteTure();
    w.DrawWorld();
    Thread.Sleep(1000);
    Console.SetCursorPosition(0,0);
}