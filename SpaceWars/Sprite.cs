using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWars
{
    abstract internal class Sprite
    {
        protected Sprite(Control container)
        {
            Pb = new PictureBox();
            container.Controls.Add(Pb);
        }

        public PictureBox Pb { get; }
        public int SpeedX { get; set; }
        public int SpeedY { get; set; }

        public void Move()
        {
            Pb.Left += SpeedX;
            Pb.Top += SpeedY;
        }
    }
}
