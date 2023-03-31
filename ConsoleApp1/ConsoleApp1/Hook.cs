using ConsoleApp1.CombatSkill;
using ConsoleApp1.Monster;
using ConsoleApp1.IUseSkill;

namespace ConsoleApp1.Hook
{
    class Hook : CombatSkill.CombatSkill, IUseSkill.IUseSkill
    {
        public void use(Monster.Monster mob)
        {
            mob.setHealth(mob.getHealth() - 100);
        }
    }
}