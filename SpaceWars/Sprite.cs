﻿using System;
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
            Pb.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public PictureBox Pb { get; }
        public int SpeedX { get; set; }
        public int SpeedY { get; set; }

        public virtual void Move()
        {
            Pb.Left += SpeedX;
            Pb.Top += SpeedY;
        }

        public bool IsCollide(Sprite another)
        {
            if(another == null || another == this) return false;
            Rectangle r1 = new Rectangle(Pb.Location, Pb.Size);
            Rectangle r2 = new Rectangle(another.Pb.Location, another.Pb.Size);
            return r1.IntersectsWith(r2);
        }

        public abstract void Collide(Sprite another, Game game);
    }
}
