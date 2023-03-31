using ConsoleApp1.Name;

namespace ConsoleApp1.CombatSkill
{
    abstract class CombatSkill : Name.Name
    {
        public CombatSkill()
        {
            this.name = this.GetType().Name;
        }
    }
}