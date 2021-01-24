using System;
using System.Collections.Generic;
using System.Text;

namespace VivifyIdeasTask.Monsters
{
    public class AttackType : IAttackType
    {
        public virtual int Damage { get; }

        public string Name { get; }

        public AttackType(int damage, string name)
        {
            Damage = damage;
            Name = name;
        }
    }
}
