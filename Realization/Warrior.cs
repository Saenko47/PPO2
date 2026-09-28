using PPOLAB2.Base;
using System;
using System.Collections.Generic;
using System.Text;
using static PPOLAB2.Tools.Enums;

namespace PPOLAB2.Realization
{
    internal class Warrior:BaseUnit
    {
        public override AttackToType attackType => AttackToType.Melee;

        public override Warrior Clone()
        {
            throw new NotImplementedException();
        }
    }
}
