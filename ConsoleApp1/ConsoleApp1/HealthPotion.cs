using ConsoleApp1.IDrink;
using ConsoleApp1.Potion;
using ConsoleApp1.Player;

namespace ConsoleApp1.HealthPotion
{
    class HealthPotion : Potion.Potion, IDrink.IDrink
    {
        public HealthPotion(int size) : base(size)
        {
        }

        public void drink(Player.Player player)
        {
            player.addHealth(this.size * 100);
        }
    }
}