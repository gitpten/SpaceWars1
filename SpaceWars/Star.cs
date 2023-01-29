using SpaceWars.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWars
{
    internal class Star : Sprite
    {
        private static readonly Random random = new Random();
        public Star(Control container) : base(container)
        {
            Pb.Image = Resources.star;
            Pb.SizeMode = PictureBoxSizeMode.Zoom;
            int size = random.Next(50, 250);
            Pb.Size = new Size(size, size);
            Pb.Left = container.Width * 15 / 10;
            Pb.Top = random.Next(container.ClientSize.Height - size);
            SpeedX = -random.Next(5, 20);
        }
    }
}
