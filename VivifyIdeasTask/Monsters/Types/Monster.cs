using System;
using System.Collections.Generic;
using System.Text;

namespace VivifyIdeasTask.Monsters.Types
{
    public class Monster : IMonster
    {
        public int Health { get; private set; }
        public bool IsDead => Health == 0;
        public IAttackType[] AttackTypes { get; }
        public string Name { get; }

        public Monster(int health, IAttackType[] attackTypes, string name)
        {
            Health = health;
            AttackTypes = attackTypes;
            Name = name;
        }

        public void SubtractHealth(int health)
        {
            int newHealth = Health - health;
            if (newHealth < 0)
            {
                Health = 0;
                return;
            }

            Health = newHealth;
        }
    }
}
