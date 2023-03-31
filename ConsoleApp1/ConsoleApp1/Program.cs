using System;
using System.Collections.Generic;

using ConsoleApp1.TimeHelper;
using ConsoleApp1.Name;
using ConsoleApp1.Price;

using ConsoleApp1.Shield;
using ConsoleApp1.Weapon;

using ConsoleApp1.Potion;
using ConsoleApp1.HealthPotion;
using ConsoleApp1.StrenghtPotion;

using ConsoleApp1.IGetName;
using ConsoleApp1.IUseSkill;

using ConsoleApp1.CombatSkill;
using ConsoleApp1.Hook;
using ConsoleApp1.Energyball;
using ConsoleApp1.Kraccbacc;

using ConsoleApp1.BasePerson;
using ConsoleApp1.Player;
using ConsoleApp1.Tank;
using ConsoleApp1.Rogue;
using ConsoleApp1.Barbar;
using ConsoleApp1.Monster;
using ConsoleApp1.Event;

using ConsoleApp1.Engine;

namespace Program
{
    internal class Program
    {
        static string inputText(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }

        static void Main()
        {
            Random rand = new Random();
            Engine engine = new Engine(new Random());
            Player player = engine.createPlayer(inputText("Enter you nickname: "), inputText("Enter your new character(barbar, tank, rogue): "));
            Event events = new Event(player, new Random());
            Console.Clear();


            player.setWeapon(engine.createWeapon(inputText("Enter your new weapon(AK-47, lightsaber, spear, axe, Cesium-137(Cs-137,Cs), bow): ")));
            Console.Clear();

            string choose = inputText(engine.generateArmorShopText());

            if (engine.checkArmor(choose))
            {
                player.setShield(engine.createShield(choose));
            }
            else
            {
                Console.WriteLine("Error!");
                return;
            }

            Console.Clear();
            player.showInfo();
            player.showEquipment();

            while (true)
            {
                int chance = rand.Next(1, 101);
                if (chance <= 5)
                {
                    events.mainPage(events.typeNameInt("Choose the option(1 - buy weapon, 2 - buy shield, 3 - buy potion, 4 - continue game"));
                }
                else if (chance > 5 && chance <= 30)
                {
                    events.increaseCharacter(rand.Next(1, 9));
                }
                else if (chance > 30 && chance <= 70)
                {
                    events.meetMonster();
                }
                else
                {
                    events.nothing();
                }
            }
        }
    }
}
