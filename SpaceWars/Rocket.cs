using SpaceWars.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWars
{
    internal class Rocket : Sprite
    {
        private Ship ship;
        private bool pushed;
        List<Image> costumes = new List<Image>();
        private int activecostume = 0;
        public Rocket(Control container, Ship ship) : base(container)
        {
            costumes.AddRange(new Image[] { Resources.rocket1, Resources.rocket2, Resources.rocket3 });
            this.ship = ship;
            Pb.Size = new Size(ship.Pb.Width / 2, ship.Pb.Height / 2);
            pushed = false;
            Pb.Visible = pushed;
        }


        public override void Move()
        {
            if (!pushed)
                Pb.Location = ship.Pb.Location;
            else
            {
                base.Move();
                activecostume++;
                Pb.Image = costumes[activecostume % costumes.Count];
                if (Pb.Left > Container.Width) pushed = false;
            }
        }

        internal override void Collide(Game game, Sprite target)
        {
            var eTarget = target as EnvironmentSprite;
            if (eTarget == null) return;
            eTarget.GoToStart();
            Stop();
        }

        private void Stop()
        {
            SpeedX = 0;
            Pb.Visible = false;
            pushed = false;
        }

        public void Push()
        {
            SpeedX = 50;
            Pb.Visible = true;
            pushed = true;
        }
    }
}
