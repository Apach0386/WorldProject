namespace WorldProject.Plants
{
    internal class Guarana : Plant
    {
        public Guarana(int x, int y) : base(x, y)
        {
        }

        public override void Collision(Organism organism)
        {
            if (organism is Animal)
            {
                organism.Power += 3;
            }
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write('g');
            Console.ResetColor();
        }

        protected override Plant CreateClone(int x, int y)
        {            
            return new Guarana(x, y);            
        }
    }
}
