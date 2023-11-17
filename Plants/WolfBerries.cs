namespace WorldProject.Plants
{
    internal class WolfBerries : Plant
    {

        public WolfBerries(int x, int y) : base(x, y)
        {
            Power = 99;
        }


        public override void Collision(Organism organism)
        {
            organism.IsLife = false;
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write('W');
            Console.ResetColor();
        }

        protected override Plant CreateClone(int x, int y)
        {
            return new WolfBerries(x, y);
        }
    }
}
