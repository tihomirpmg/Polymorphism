using System;
using System.Collections.Generic;
using System.Text;

namespace _2._4.Raiding
{
    public class Rogue : BaseHero
    {
        public Rogue(string name) : base(name)
        { }

        public override int Power => GlobalConsts.RogueAndDruidPower;

        public override string CastAbility()
        {
            return string.Format(GlobalConsts.StringOverrideRodueWarrior, GetType().Name, Name, Power);
        }
    }
}
