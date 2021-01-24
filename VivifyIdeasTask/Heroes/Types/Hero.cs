using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VivifyIdeasTask.Heroes.Weapons;

namespace VivifyIdeasTask.Heroes.Types
{
    public class Hero : IHero
    {
        public virtual int Health { get; private set; }
        public virtual bool IsDead => Health == 0;

        public virtual int MaxWeaponCount { get; }
        public virtual IHeroWeapon[] Weapons { get; private set; }
        public virtual string Name { get; }
        protected virtual HashSet<IHeroWeapon> PermittedWeapons { get; }

        protected int ActiveWeaponIndex { get; private set; }
        public IHeroWeapon ActiveWeapon
        {
            get
            {
                if (Weapons.Length == 0)
                {
                    return null;
                }

                if (ActiveWeaponIndex == -1)
                {
                    return null;
                }

                return Weapons[ActiveWeaponIndex];
            }
        }

        public Hero(int health, int maxWeaponCount, IHeroWeapon[] initialWeapons, IEnumerable<IHeroWeapon> permittedWeapons, string name)
        {
            if (initialWeapons.Length > maxWeaponCount)
            {
                throw new BackpackFullException($"Maksimalan broj oružja u rancu je {maxWeaponCount}");
            }

            Health = health;
            MaxWeaponCount = maxWeaponCount;
            Weapons = initialWeapons;
            Name = name;
            PermittedWeapons = new HashSet<IHeroWeapon>(permittedWeapons);

            ActiveWeaponIndex = 0;
        }

        public virtual void SwitchWeapons()
        {
            if (Weapons.Length == 0)
            {
                throw new NoWeaponException("Nema oružja u rancu");
            }

            int idx = Array.FindIndex(Weapons, w => w != null); // next one that is not null
            ActiveWeaponIndex = idx;
        }

        public virtual IHeroWeapon DropWeapon()
        {
            if (Weapons.Length == 0)
            {
                return null; // no exception here by PDF task definition / requirements
            }

            var weapon = Weapons[ActiveWeaponIndex];
            Weapons = Weapons.Except(new[] { weapon }).ToArray();

            // next one that is not null;
            int idx = Array.FindIndex(Weapons, w => w != null); // next one that is not null
            ActiveWeaponIndex = idx;

            return weapon;
        }

        public virtual bool CanUseWeapon(IHeroWeapon weapon)
        {
            return PermittedWeapons.Contains(weapon);
        }

        public virtual void PickUpWeapon(IHeroWeapon weapon)
        {
            if (!CanUseWeapon(weapon))
            {
                throw new IllegalWeaponException($"'{Name}' ne može koristiti oružje '{weapon.Name}'");
            }

            if (Weapons.Length == MaxWeaponCount)
            {
                throw new BackpackFullException("Ranac je pun");
            }

            Weapons = Weapons.Union(new[] { weapon }).ToArray();
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
