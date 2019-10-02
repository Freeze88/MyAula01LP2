using System;
using System.Collections.Generic;
using System.Text;

namespace MyAulda01
{
    class Player
    {
        public float Hp { get => Hp; private set { Hp = (value < 0) ? 0 : (value > 100) ? 100 : value; } }
        public string Skin { get; }
        public static float MaxHp { get; } = 100f;

        public Player(string skin)
        {
            this.Hp = MaxHp;
            Skin = skin;
        }
        private void TakeDamage(float damage)
        {
            Hp = MathF.Max(0, Hp - damage);
        }
        private void Heal(float heal)
        {
            Hp = MathF.Min(MaxHp, Hp + heal);
        }
        public void Shoot(Player PL2)
        {
            PL2.TakeDamage(10);
        }
    }
}
