using PPOLAB2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static PPOLAB2.Tools.Enums;

namespace PPOLAB2.Base
{
    internal abstract class BaseUnit: IClone<BaseUnit>
    {
        public Race race { get; set; }
        public MoveType moveType { get; set; }

        public int health { get; set; }

        public virtual AttackToType attackType { get; set; }

        public abstract BaseUnit Clone();

    }
}
