using PPOLAB2.Realization;
using PPOLAB2.Requests.ArcherRequest;
using System;
using System.Collections.Generic;
using System.Text;

namespace PPOLAB2.Interfaces.Fabrics
{
    internal interface IArcherFabric
    {
        Archer CreateArcher(ArcherCreateRequest req);
    }
}
