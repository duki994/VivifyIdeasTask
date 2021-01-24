using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using VivifyIdeasTask.Heroes.Weapons;

namespace VivifyIdeasTask.Heroes.Types
{
    public class Wizard : Hero
    {
        public Wizard() : base(
            health: 150,
            maxWeaponCount: 2,
            initialWeapons: new IHeroWeapon[] { new Magic(20) },
            permittedWeapons: new IHeroWeapon[] { new Magic(20) },
            name: "Čarobnjak"
        )
        {
        }
    }
}
