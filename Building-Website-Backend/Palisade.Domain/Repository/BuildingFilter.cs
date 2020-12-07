using Palisade.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palisade.Domain.Repository
{
    public static partial class BuildingFilter
    {
        public static Building WithBuildingId(this IQueryable<Building> building, long buildingId)
        {
            return building.SingleOrDefault(p => p.Id == buildingId);
        }
    }
}
