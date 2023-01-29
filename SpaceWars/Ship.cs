using SpaceWars.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWars
{
    internal class Ship: Sprite
    {
        public Ship(Control container) : base(container)
        {
            Pb.Image = Resources.ufo;
            Pb.Size = new Size(200, 100);
            Pb.Left = container.Width  / 5;
            Pb.Top = container.ClientSize.Height / 2;
        }

        internal override void Collide(Game game, Sprite target) { }
    }
}
