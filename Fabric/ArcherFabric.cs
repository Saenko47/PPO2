using PPOLAB2.Interfaces.Fabrics;
using PPOLAB2.Realization;
using PPOLAB2.Requests.ArcherRequest;
using System;
using System.Collections.Generic;
using System.Text;

namespace PPOLAB2.Fabric
{
    internal class ArcherFabric: IArcherFabric
    {
        public Archer CreateArcher(ArcherCreateRequest req) 
        {
            Archer newArcher = new Archer { race = req.race, moveType = req.moveType, health = req.health, attackType = req.attackType };
            return newArcher;
        }
    }
}
