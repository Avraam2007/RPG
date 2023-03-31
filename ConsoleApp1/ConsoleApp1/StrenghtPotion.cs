using ConsoleApp1.IDrink;
using ConsoleApp1.Potion;
using ConsoleApp1.Player;

namespace ConsoleApp1.StrenghtPotion 
{
    class StrenghtPotion : Potion.Potion, IDrink.IDrink
    {
        public StrenghtPotion(int size) : base(size)
        {
        }
        public void drink(Player.Player player)
        {
            int[] values = { 1, 3, 6 };

            player.addPower(values[this.size - 1]);
        }
    }
}