using ConsoleApp1.Name;
using ConsoleApp1.Price;

namespace ConsoleApp1.Weapon
{
    class Weapon : Price.Price
    {
        protected int damage = 0;
        public Weapon(int damage, string name, int price = 0) : base(name, price)
        {
            this.setName(name);
            this.damage = damage;
            this.setPrice(price);
        }

        public void setDamage(int damage)
        {
            this.damage = damage;
        }

        public int getDamage() => this.damage;

        ~Weapon()
        {

        }
    };

}
