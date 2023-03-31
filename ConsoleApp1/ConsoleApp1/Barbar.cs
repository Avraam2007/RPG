using ConsoleApp1.Player;

namespace ConsoleApp1.Barbar
{
    class Barbar : Player.Player
    {
        public Barbar(string name) : base(name, 300)
        {
            this.power = 15;
            this.agility = 10;
            this.endurance = 10;
        }
    }
}