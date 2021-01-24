using VivifyIdeasTask.Monsters.Attacks;

namespace VivifyIdeasTask.Monsters.Types
{
    public class Spider : Monster
    {
        public Spider() : base(
            health: 100,
            attackTypes: new AttackType[] { new Hit(), new Bite() },
            name: "Pauk"
        )
        {
        }
    }
}
