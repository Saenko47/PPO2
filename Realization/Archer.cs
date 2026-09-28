using PPOLAB2.Base;
using PPOLAB2.Tools;
using System;
using System.Collections.Generic;
using System.Text;
using static PPOLAB2.Tools.Enums;

namespace PPOLAB2.Realization
{
    internal class Archer:BaseUnit
    {
        public override AttackToType attackType => AttackToType.Ranged;

        public override Archer Clone()
        {
            throw new NotImplementedException();
        }
    }
}
