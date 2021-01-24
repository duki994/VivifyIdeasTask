using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VivifyIdeasTask.Heroes;
using VivifyIdeasTask.Heroes.Types;
using VivifyIdeasTask.Heroes.Weapons;
using VivifyIdeasTask.Monsters.Types;

namespace VivifyIdeasTask.Game
{
    public class GameSimulation
    {
        public HeroFactory HeroFactory { get; }
        public MonsterFactory MonsterFactory { get; }


        public GameSimulation()
        {
            HeroFactory = new HeroFactory();
            MonsterFactory = new MonsterFactory();
        }


        public void SimulateGame()
        {
            IHero hero = HeroFactory.CreateHero();
            IMonster monster = MonsterFactory.CreateMonster();

            while (!hero.IsDead && !monster.IsDead)
            {
                var rng = new Random();
                int num = rng.Next(0, 100);

                if (num < 50)
                {
                    var w = hero.ActiveWeapon;
                    monster.SubtractHealth(w.Damage);

                    Console.WriteLine($"'{hero.Name}' je napao/la žrtvu '{monster.Name}' pomoću oružja '{w.Name}'");
                }
                else
                {
                    var attack = monster.AttackTypes[rng.Next(0, monster.AttackTypes.Length)];
                    hero.SubtractHealth(attack.Damage);

                    Console.WriteLine($"'{monster.GetType().Name}' je napao/la '{hero.GetType().Name}' pomoću oružja '{attack.Name}'");
                }
            }

            if (hero.IsDead)
            {
                Console.WriteLine($"'{hero.Name}' je pobedio/la u duelu sa '{monster.Name}'");
            }
            else
            {
                Console.WriteLine($"'{monster.Name}' je pobedio/la u duelu sa '{hero.Name}'");
            }
        }

        public void SimulateWeaponDropAndPickup()
        {
            IHero wizard = HeroFactory.CreateWizard();
            IHero swordsman = HeroFactory.CreateSwordsman();

            IHeroWeapon magic = wizard.DropWeapon();
            IHeroWeapon _ = wizard.DropWeapon();

            swordsman.PickUpWeapon(new Spear(15));

            try
            {
                swordsman.PickUpWeapon(magic);
            }
            catch (BackpackFullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IllegalWeaponException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void SimulateDropAndPickupByOtherHero()
        {
            IHero swordsmanOne = HeroFactory.CreateSwordsman();
            IHero swordsmanTwo = HeroFactory.CreateSwordsman();

            IHeroWeapon w = swordsmanOne.DropWeapon();
            IHeroWeapon _ = swordsmanTwo.DropWeapon();


            swordsmanTwo.PickUpWeapon(w);

            Console.WriteLine($"'{swordsmanTwo.Name}' je pokupio oružje '{w.Name}'");
        }
    }
}
