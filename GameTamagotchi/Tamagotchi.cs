using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagotchiPlay
{
    public class Tamagotchi
    {
        public int Health { get; set; }
        public int Hunger { get; set; }
        public int Fatigue { get; set; }
        public Tamagotchi(int health, int hunger, int fatigue)
        {
            Health = health;
            Hunger = hunger;
            Fatigue = fatigue;
        }
        public void Feed()
        {
            Hunger -= 1;
            if (Hunger <= 0)
            {
                if (Health <= 0)
                {
                    Console.WriteLine("К сожалению, Вы проиграли");
                }
                else
                {
                    Health -= 1;
                }
                Hunger = 0;
            }
        }
        public void Play()
        {
            if (Fatigue >= 10)
            {
                Health -= 1;
                if (Hunger < 10)
                {
                    Hunger += 1;
                }
            }
            else
            {
                Fatigue += 1;
            }
        }
        public void Rock()
        {
            if (Health >= 10)
            {
                Health = 10;
            }
            else
            {
                Health += 1;
            }
            Fatigue = 0;
            if (Hunger >= 10)
            {
                Health -= 1;
                Hunger = 10;
            }
            else
            {
                Hunger += 1;
            }

        }
    }
}