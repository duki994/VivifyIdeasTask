using System.Collections.Generic;
using VivifyIdeasTask.Heroes.Weapons;

namespace VivifyIdeasTask.Heroes.Types
{
    public class Swordsman : Hero
    {
        public Swordsman() : base(
            health: 100,
            maxWeaponCount: 2,
            initialWeapons: new IHeroWeapon[] { new Sword(10) },
            permittedWeapons: new IHeroWeapon[] { new Sword(10), new Spear(15) },
            name: "Mačevalac")
        {
        }
    }
}
