using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWars
{
    internal class Game
    {
        public bool IsOver { get; set; } = false;
        public int Score { get; set; } = 0;
        public Ship Ship { get; }
        public List<Sprite> Sprites { get; } = new List<Sprite>();

        public Game(Control container)
        {
            Ship = new Ship(container);
            Sprites.Add(Ship);
            for (int i = 0; i < 5; i++)
            {
                Sprites.Add(new Star(container));
            }
            for (int i = 0; i < 3; i++)
            {
                Sprites.Add(new Rock(container));
            }
        }

        public void Update()
        {
            foreach (var sprite in Sprites)
            {
                sprite.Move();
                if (Ship.IsCollide(sprite)) sprite.Collide(Ship, this);
            }
        }

        internal void ScoreUp()
        {
            Score += 10;
        }

        internal void Over()
        {
            IsOver = true;
        }
    }
}
