using ConsoleApp1.IGetName;
using ConsoleApp1.Monster;

namespace ConsoleApp1.IUseSkill
{
    interface IUseSkill : IGetName.IGetName
    {
        void use(Monster.Monster monster);
    }
}