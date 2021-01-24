using VivifyIdeasTask.Heroes.Weapons;

namespace VivifyIdeasTask.Heroes.Types
{
    public interface IHero
    {
        int Health { get; }
        bool IsDead { get; }
        int MaxWeaponCount { get; }
        IHeroWeapon[] Weapons { get; }
        IHeroWeapon ActiveWeapon { get; }
        string Name { get; }

        bool CanUseWeapon(IHeroWeapon weapon);
        IHeroWeapon DropWeapon();
        void PickUpWeapon(IHeroWeapon weapon);
        void SubtractHealth(int health);
        void SwitchWeapons();
    }
}