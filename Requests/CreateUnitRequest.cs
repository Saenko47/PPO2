using System;
using System.Collections.Generic;
using System.Text;
using static PPOLAB2.Tools.Enums;

namespace PPOLAB2.Requests
{
    internal class CreateUnitRequest
    {
        public int Health { get; set; }
        public Race race { get; set; }
        public MoveType moveType { get; set; }
        
    }
}
