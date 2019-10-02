using System;
using System.Collections.Generic;
using System.Text;

namespace MyAulda01
{
    class Player
    {
        float Hp;
        string type;

        private void TakeDamage(float damage)
        {
            Hp = MathF.Max(0, Hp - damage);
        }
        private void Heal(float heal)
        {
            Hp = MathF.Min(100, Hp + heal);
        }
        private void Shoot(Player PL2)
        {
            PL2.TakeDamage(10);
        }
    }
}
