using ConsoleApp1.Player;

namespace ConsoleApp1.Tank
{
    class Tank : Player.Player
    {
        public Tank(string name) : base(name, 1200)
        {
            this.power = 10;
            this.agility = 5;
            this.endurance = 20;
        }
    }
}