using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWars
{
    internal class Game
    {
        public bool GameOver { get; set; } = false;
        public int Score { get; set; } = 0;
        public Rocket Rocket { get; }
        public Ship Ship { get; }
        public Game(Control container)
        {
            Ship = new Ship(container);
            Sprites.Add(Ship);
            for (int i = 0; i < 5; i++)
            {
                Sprites.Add(new Star(container));
            }
            Rocket = new Rocket(container, Ship);
            Sprites.Add(Rocket);
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
                foreach (var target in Sprites)
                {
                    if (sprite.IsCollide(target)) sprite.Collide(this, target);
                }
            }
        }

        internal void Over()
        {
            GameOver = true;
        }

        internal void ScoreUp()
        {
            Score += 10;
        }

        internal void Shot()
        {
            Rocket.Push();
        }

        public List<Sprite> Sprites { get; set; } = new List<Sprite>();

    }
}
