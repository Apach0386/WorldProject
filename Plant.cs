using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldProject.Plants;

namespace WorldProject
{
    internal abstract class Plant : Organism
    {
        public Plant(int x, int y) : base(x, y)
        {
        }

        public override void Action(World world)
        {
            int probability = Random.Shared.Next(0, 100);

            if (probability < 75)
            {
                return;
            }

            int xR = Random.Shared.Next(-1, 2);
            int yR = Random.Shared.Next(-1, 2);

            Plant plant = CreateClone(this.X + xR, this.Y + yR);

            world.AddOrganism(plant);
        }

        protected abstract Plant CreateClone(int x, int y);

        public override void Collision(Organism organism)
        {
            if (organism.Power > this.Power)
            {
                this.IsLife = false;
            }
        }

    }

}
