using System;
using System.Collections.Generic;
using System.Text;
using static PPOLAB2.Tools.Enums;

namespace PPOLAB2.Base
{
    internal abstract class BaseUnit
    {
        public Race race { get; set; }
        public MoveType moveType { get; set; }

        public int health { get; set; }

    }
}
