using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using VivifyIdeasTask.Heroes.Types;

namespace VivifyIdeasTask.Heroes.Weapons
{
    public class Magic : IHeroWeapon, IEquatable<IHeroWeapon>
    {
        public int Damage { get; }

        public string Name { get; } = "Čarolija";

        public Magic(int damage)
        {
            Damage = damage;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Damage, typeof(Magic).FullName.GetHashCode());
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

            if (other.GetType().FullName != typeof(Magic).FullName)
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
