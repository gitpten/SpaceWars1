﻿using SpaceWars.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWars
{
    internal class Star : EnvironmentSprite
    {
        public Star(Control container) : base(container)
        {
            Pb.Image = Resources.star;
        }

        internal override void Collide(Game game, Sprite target)
        {
            if (target is Ship)
            {
                game.ScoreUp();
                GoToStart();
            }
        }
    }
}
