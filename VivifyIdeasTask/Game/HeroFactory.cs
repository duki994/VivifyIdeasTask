using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using VivifyIdeasTask.Heroes.Types;
using VivifyIdeasTask.Monsters.Types;

namespace VivifyIdeasTask.Game
{
    public class HeroFactory
    {
        private readonly IReadOnlyDictionary<int, Type> _intHeroMap = new ReadOnlyDictionary<int, Type>(
            new Dictionary<int, Type>
            {
                [0] = typeof(Wizard),
                [1] = typeof(Swordsman)
            }
        );

        public HeroFactory()
        {
        }

        public IHero CreateHero()
        {
            var rng = new Random();
            int num = rng.Next(0, 2);

            return (IHero) Activator.CreateInstance(_intHeroMap[num]);
        }

        public Wizard CreateWizard()
        {
            return new Wizard();
        }

        public Swordsman CreateSwordsman()
        {
            return new Swordsman();
        }
    }
}
