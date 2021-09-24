using System;
using System.Collections.Generic;
using System.Text;

namespace _2._4.Raiding
{
    public class Druid : BaseHero
    {
        public Druid(string name) : base(name)
        { }

        public override int Power => GlobalConsts.RogueAndDruidPower;

        public override string CastAbility()
        {
            return string.Format(GlobalConsts.StringOverrideDruidPaladin, GetType().Name, Name, Power);
        }
    }
}
