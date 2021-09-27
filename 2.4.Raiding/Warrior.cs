using System;
using System.Collections.Generic;
using System.Text;

namespace _2._4.Raiding
{
    public class Warrior : BaseHero
    {
        public Warrior(string name) : base(name)
        { }

        public override int Power => GlobalConsts.PaladinAndWarriorPower;

        public override string CastAbility()
        {
            return string.Format(GlobalConsts.StringOverrideRodueWarrior, GetType().Name, Name, Power);
        }
    }
}
