namespace VivifyIdeasTask.Monsters.Types
{
    public interface IMonster
    {
        IAttackType[] AttackTypes { get; }
        int Health { get; }
        bool IsDead { get; }
        string Name { get; }

        void SubtractHealth(int health);
    }
}