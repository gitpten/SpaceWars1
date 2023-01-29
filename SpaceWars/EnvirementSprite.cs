using SpaceWars.Properties;
using System.ComponentModel;
using System.Drawing;

namespace SpaceWars
{
    internal abstract class EnvironmentSprite: Sprite
    {
        private static readonly Random random = new Random();



        public void GoToStart()
        {
            Pb.Left = Container.Width * 15 / 10;
            Pb.Top = random.Next(Container.ClientSize.Height - Pb.Height);
        }

        public override void Move()
        {
            base.Move();
            if (Pb.Left < -Pb.Width)
                GoToStart();
        }

        public EnvironmentSprite(Control container) : base(container)
        {
            int size = random.Next(10, 50);
            Pb.Size = new Size(size, size);
            GoToStart();
            SpeedX = -random.Next(5, 20);
        }
    }
}