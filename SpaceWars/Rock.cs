using SpaceWars.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWars
{
    internal class Rock : EnvironmentSprite
    {
        public Rock(Control container) : base(container)
        {
            Pb.Image = Resources.rock;
        }

        internal override void Collide(Game game, Sprite target)
        {
            if (target is Ship) game.Over();
        }
    }
}
