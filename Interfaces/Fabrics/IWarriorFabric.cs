using PPOLAB2.Realization;
using PPOLAB2.Requests.WarriorsRequests;
using System;
using System.Collections.Generic;
using System.Text;
using static PPOLAB2.Tools.Enums;

namespace PPOLAB2.Interfaces.Fabrics
{
    internal interface IWarriorFabric
    {
        Warrior CreateWarrior(WarriorCreateRequest req);
    }
}
