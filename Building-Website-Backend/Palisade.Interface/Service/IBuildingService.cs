using Palisade.Domain.Entity;
using Palisade.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Palisade.Service
{
    public interface IBuildingService
    {
        List<Building> List();

        BuildingDTO View(long buildingId);
    }
}
