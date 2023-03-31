using ConsoleApp1.Player;

namespace ConsoleApp1.IDrink
{
    interface IDrink : IGetName.IGetName
    {
        void drink(Player.Player player);
    }
}