using SpaceWars.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWars
{
    internal class Star : EnvirenmentSprite
    {
        public Star(Control container) : base(container)
        {           
            Pb.Image = Resources.star;           
        }

        public override void Collide(Sprite another, Game game)
        {
            if(another is Ship)
            {
                game.ScoreUp();
                GoToStart();
            }
        }
    }
}
