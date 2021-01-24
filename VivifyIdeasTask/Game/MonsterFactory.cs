using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using VivifyIdeasTask.Monsters.Types;

namespace VivifyIdeasTask.Game
{
    public class MonsterFactory
    {
        private readonly IReadOnlyDictionary<int, Type> _intMonsterMap = new ReadOnlyDictionary<int, Type>(
            new Dictionary<int, Type>
            {
                [0] = typeof(Dragon),
                [1] = typeof(Spider)
            }
        );

        public MonsterFactory()
        {
        }

        public IMonster CreateMonster()
        {
            var rng = new Random();
            int num = rng.Next(0, 2);

            return (IMonster) Activator.CreateInstance(_intMonsterMap[num]);
        }
    }
}
