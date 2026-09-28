using PPOLAB2.Interfaces.Fabrics;
using PPOLAB2.Realization;
using PPOLAB2.Requests.WarriorsRequests;
using System;
using System.Collections.Generic;
using System.Text;

namespace PPOLAB2.Fabric
{
    internal class WarriorFabric:IWarriorFabric
    {
        public Warrior CreateWarrior(WarriorCreateRequest req) 
        {
            Warrior newWarrior = new Warrior { race = req.race, attackType = req.attackType, health = req.Health, moveType = req.moveType };
            return newWarrior;
        }
    }
}
