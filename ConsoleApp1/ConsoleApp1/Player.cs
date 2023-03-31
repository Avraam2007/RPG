using ConsoleApp1.IDrink;
using ConsoleApp1.Shield;
using ConsoleApp1.Weapon;
using ConsoleApp1.Monster;
using ConsoleApp1.IUseSkill;
using ConsoleApp1.BasePerson;

namespace ConsoleApp1.Player
{
    class Player : BasePerson.BasePerson
    {
        protected int power = 0;
        protected int agility = 0;
        protected int endurance = 0;
        protected int damage = 0;
        protected int protect = 0;
        protected int wallet = 0;
        protected List<IUseSkill.IUseSkill> skills;
        private IDrink.IDrink potion = null;
        private int xp = 0;
        private Shield.Shield shield = null;
        private Weapon.Weapon armament = null;
        private Random rand = null;

        public Player(string name, int hp) : base(name, 1)
        {
            this.health = hp;
            this.healthMax = hp;
            this.skills = new List<IUseSkill.IUseSkill>();
            rand = new Random();
        }

        public void setShield(Shield.Shield shield) => this.shield = shield;
        public void setWeapon(Weapon.Weapon armament) => this.armament = armament;

        public void showEquipment()
        {
            Console.WriteLine("Weapon: " + this.armament.getName() + " Value: " + this.armament.getDamage());
            Console.WriteLine("Shield: " + this.shield.getName() + " Value: " + this.shield.getProtect());
        }

        public void setWallet(int wallet) => this.wallet = wallet;

        public void setPotion(IDrink.IDrink potion) => this.potion = potion;

        private bool isPotion()
        {
            if (this.potion == null)
                return false;

            return true;
        }

        public bool drinkPotion()
        {
            if (isPotion())
            {
                this.potion.drink(this);
                this.potion = null;

                return true;
            }

            return false;
        }

        public void addSkill(IUseSkill.IUseSkill skill)
        {
            this.skills.Add(skill);
        }

        public void showSkillList()
        {
            int index = 0;

            Console.WriteLine("Choose skill: ");
            foreach (var item in this.skills)
            {
                Console.WriteLine($"{index} - {item.getName()}");
                index++;
            }
        }

        public void useSkill(int index, Monster.Monster mob)
        {
            this.skills[index].use(mob);
        }

        ~Player()
        { }

        public void setXp(int xp)
        { this.xp = xp; }

        public void addPower(int power)
        {
            this.power += power;
        }

        public void setPower(int power)
        { this.power = power; }

        public void setDamage(int damage)
        {
            if (agility % rand.Next(1, 11) == 0)
            {
                this.damage = (damage + armament.getDamage() + this.power % 100) * 2;
            }
            else
            {
                this.damage = damage + armament.getDamage() + this.power % 100;
            }
        }

        public void setProtect(int protect)
        {
            this.protect = protect + shield.getProtect() + this.endurance % 100;
        }



        public void setAgility(int agility)
        { this.agility = agility; }

        public void setEndurance(int endurance)
        { this.endurance = endurance; }

        public int getXp() => this.xp;

        public int getDamage() => this.damage;

        public int getProtect() => this.protect;

        public int getPower() => this.power;

        public int getAgility() => this.agility;

        public int getEndurance() => this.endurance;

        public int getWallet() => this.wallet;
    };
}