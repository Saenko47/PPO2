using System;
using System.Collections.Generic;
using System.Text;
using static PPOLAB2.Tools.Enums;

namespace PPOLAB2.Requests
{
    internal class CreateUnitRequest
    {
        public int health { get; set; }
        public Race race { get; set; }
        public MoveType moveType { get; set; }
        public AttackToType attackType { get; set; }
        
    }
}
