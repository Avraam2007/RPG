using ConsoleApp1.BasePerson;

namespace ConsoleApp1.Monster
{
    class Monster : BasePerson.BasePerson
    {
        private int damage = 0;
        private int protect = 0;
        private int xpPlus = 0;

        public Monster(string name, int level) : base(name, level)
        {
            this.damage = level * 11;
            this.health = level * 120;
            this.healthMax = level * 120;
            this.protect = level * 8;
            this.xpPlus = level * 20;
        }

        public void setDamage(int damage)
        { this.damage = damage; }

        public void setProtect(int protect)
        { this.protect = protect; }

        public void setXpPlus(int xpPlus)
        { this.xpPlus = xpPlus; }

        public int getDamage() => this.damage;

        public int getProtect() => this.protect;

        public int getXpPlus() => this.xpPlus;


        ~Monster()
        { }
    };
}