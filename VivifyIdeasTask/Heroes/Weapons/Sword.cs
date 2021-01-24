using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace VivifyIdeasTask.Heroes.Weapons
{
    public class Sword : IHeroWeapon, IEquatable<IHeroWeapon>
    {
        public int Damage { get; }

        public string Name { get; } = "Mač";

        public Sword(int damage)
        {
            Damage = damage;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Damage, typeof(Sword).FullName.GetHashCode());
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as IHeroWeapon);
        }

        public bool Equals([AllowNull] IHeroWeapon other)
        {
            if (other == null)
            {
                return false;
            }

            if (other.GetType().FullName != typeof(Sword).FullName)
            {
                return false;
            }

            if (other.Damage == Damage && other.Name == Name)
            {
                return true;
            }

            return false;
        }
    }
}
