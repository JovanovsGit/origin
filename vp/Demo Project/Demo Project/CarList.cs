using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Project
{
    public class CarList
    {
        public List<EnemyCar> enemies;
        public List<HeroCar> hero;
        public bool flag = false;
        public CarList()
        {
            hero = new List<HeroCar>();
            enemies = new List<EnemyCar>();
        }

        public void Draw(Graphics g)
        {
            foreach (EnemyCar e in enemies)
            {
                e.Draw(g);
            }
        }
        public void Move()
        {
            foreach (EnemyCar e in enemies)
            {
                    e.Move(new Point(e.Center.X, e.Center.Y + e.velocity));
            }
        }

        public void AddEnemy(EnemyCar e)
        {
            enemies.Add(e);
        }//////////////////////////////////////////////////////////////////////////////////////
        public void DrawHero(Graphics g)
        {
            foreach (HeroCar e in hero)
            {
                e.Draw(g);
            }
        }
        public void MoveHero(char c)
        {
            if (c == 'A')
            {
                foreach (HeroCar e in hero)
                {
                    e.Move(new Point(e.Center.X - e.velocity, e.Center.Y));
                }
            }
            if (c == 'D')
            {
                foreach (HeroCar e in hero)
                {
                    e.Move(new Point(e.Center.X + e.velocity, e.Center.Y));
                }
            }
            if (c == 'W')
            {
                foreach (HeroCar e in hero)
                {
                    e.Move(new Point(e.Center.X , e.Center.Y - e.velocity));
                }
            }
            if (c == 'S')
            {
                foreach (HeroCar e in hero)
                {
                    e.Move(new Point(e.Center.X , e.Center.Y + e.velocity));
                }
            }

        }

        public void AddHero(HeroCar e)
        {
            hero.Add(e);
        }

        public void IsHit()
        {
            for (int i = enemies.Count - 1; i >= 0; i--)  // ------->> Ovaa e vaka za sekogas topceto so e odozgore, nego da mozam da go mrdam a ne toa odzdole <<<------
            {                                           //                  a topce odozgore e poslednoto iscrtano
                if (enemies[i].IsHit(hero.ElementAt(0)))
                {
                    flag = true;
                    break;
                }
            }
        }

    }
}
