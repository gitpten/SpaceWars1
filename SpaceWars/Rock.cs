using SpaceWars.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWars
{
    internal class Rock : EnvirenmentSprite
    {
        public Rock(Control container) : base(container)
        {
            Pb.Image = Resources.rock;
        }

        public override void Collide(Sprite another, Game game)
        {
            game.Over();
        }
    }
}
