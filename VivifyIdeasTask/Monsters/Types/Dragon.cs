using System;
using System.Collections.Generic;
using System.Text;
using VivifyIdeasTask.Monsters.Attacks;

namespace VivifyIdeasTask.Monsters.Types
{
    public class Dragon : Monster
    {
        public Dragon() : base(
            health: 100,
            attackTypes: new AttackType[] { new Hit(), new Fire() },
            name: "Zmaj"
        )
        {
        }
    }
}
