using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldProject
{
    internal abstract class Plant : Organism
    {
        public Plant(int x, int y) : base(x, y)
        {
        }
    }
}
