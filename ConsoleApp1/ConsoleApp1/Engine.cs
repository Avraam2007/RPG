using ConsoleApp1.Monster;
using ConsoleApp1.Shield;
using ConsoleApp1.Weapon;
using ConsoleApp1.Player;
using ConsoleApp1.Barbar;
using ConsoleApp1.Tank;
using ConsoleApp1.Rogue;
using ConsoleApp1.Hook;
using ConsoleApp1.Energyball;
using ConsoleApp1.Kraccbacc;

namespace ConsoleApp1.Engine
{
    class Engine
    {
        private List<string> armorNames = null;
        private List<string> weaponNames = null;
        private Random rand = null;
        private string[] list = new string[] { "Сyclop", "Minotaur", "Deymos", "Troll", "Orc", "Elf", "Wizzard", "Illager", "Skeleton", "Murder" };

        public Engine(Random rand)
        {
            this.rand = rand;
            this.fillArmorNames();
            this.fillWeaponNames();
        }


        private void fillArmorNames()
        {
            this.armorNames = new List<string>();

            this.armorNames.Add("spear");
            this.armorNames.Add("lightsaber");
            this.armorNames.Add("bow");
            this.armorNames.Add("fireball");
            this.armorNames.Add("axe");
            this.armorNames.Add("AK-47");
            this.armorNames.Add("Cesium-137");
        }

        private void fillWeaponNames()
        {
            this.weaponNames = new List<string>();

            this.weaponNames.Add("package ATB");
            this.weaponNames.Add("wood");
            this.weaponNames.Add("stone");
            this.weaponNames.Add("steel");
            this.weaponNames.Add("IRIS");
            this.weaponNames.Add("diamond");
            this.weaponNames.Add("magic shield");
        }

        public string generateWeaponShopText()
        {
            return generateShopPhrase("Enter your new weapon", this.weaponNames);
        }

        public string generateArmorShopText()
        {
            return generateShopPhrase("Enter your new shield", this.armorNames);
        }

        private string generateShopPhrase(string basePhrase, List<string> names)
        {
            basePhrase += "(";

            for (int i = 0; i < names.Count; i++)
            {
                basePhrase += names[i];

                if (i != names.Count - 1)
                    basePhrase += ", ";
            }

            basePhrase += "): ";

            return basePhrase;
        }



        public Monster.Monster createMonster(int level)
        {
            return new Monster.Monster(this.list[rand.Next(0, list.GetLength(0))], (level + rand.Next(-1, 2)));
        }

        public bool checkWeapon(string choose1)
        {
            if (this.weaponNames.IndexOf(choose1) == -1)
                return false;
            else
                return true;
        }

        public Weapon.Weapon createWeapon(string choose1)
        {
            int[] protectList = { 3, 5, 7, 9, 11, 15, 20 };

            int index = this.weaponNames.IndexOf(choose1);

            return new Weapon.Weapon(protectList[index], this.weaponNames[index]);
        }

        public bool checkArmor(string choose2)
        {
            if (this.armorNames.IndexOf(choose2) == -1)
                return false;
            else
                return true;
        }

        public Shield.Shield createShield(string choose2)
        {
            int[] protectList = { 3, 5, 7, 9, 11, 15, 20 };

            int index = this.armorNames.IndexOf(choose2);

            return new Shield.Shield(protectList[index], this.armorNames[index]);
        }

        public Player.Player createPlayer(string name, string choose)
        {
            Player.Player player = null;

            if (choose == "barbar")
            {
                player = new Barbar.Barbar(name);
            }
            else if (choose == "tank")
            {
                player = new Tank.Tank(name);
            }
            else if (choose == "rogue")
            {
                player = new Rogue.Rogue(name);
            }

            player.addSkill(new Hook.Hook());
            player.addSkill(new Energyball.Energyball());
            player.addSkill(new Kraccbacc.Kraccbacc());

            player.showInfo();

            return player;
        }

    }
}