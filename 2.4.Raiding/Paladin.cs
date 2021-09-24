using System;
using System.Collections.Generic;
using System.Text;

namespace _2._4.Raiding
{
    public class Paladin : BaseHero
    {
        public Paladin(string name) : base(name)
        { }

        public override int Power => GlobalConsts.PaladinAndWarriorPower;

        public override string CastAbility()
        {
            return string.Format(GlobalConsts.StringOverrideDruidPaladin, GetType().Name, Name, Power);
        }
    }
}
