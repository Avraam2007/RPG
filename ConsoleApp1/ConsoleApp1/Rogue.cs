using ConsoleApp1.Player;

namespace ConsoleApp1.Rogue
{
    class Rogue : Player.Player
    {
        public Rogue(string name) : base(name, 400)
        {
            this.power = 10;
            this.agility = 20;
            this.endurance = 5;
        }
    }
}