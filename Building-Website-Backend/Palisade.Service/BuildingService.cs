using Palisade.Domain.Entity;
using Palisade.Domain.Repository;
using Palisade.Interface.Domain;
using Palisade.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palisade.Service
{
    public class BuildingService : IBuildingService
    {
        IRepository _repository;
        public BuildingService(IRepository repository) 
        {
            _repository = repository;
        }

        public List<Building> List()
        {
            var buildingList = _repository.GetBuilding().ToList();
            return buildingList;
        }

        public BuildingDTO View(long buildingId) 
        {
            BuildingDTO result = new BuildingDTO();
            var building = _repository.GetBuilding().WithBuildingId(buildingId);
            
            if (building != null) 
            {
                 result = new BuildingDTO()
                {
                    Id = building.Id,
                    BuildingName = building.BuildingName,
                    Address = building.Address,
                    Suburb = building.Suburb,
                    StreetNumber = building.StreetNumber,
                    Price = building.Price,
                    DisplayPrice = building.DisplayPrice,
                    Description = building.Description,
                    Bedroom = building.Bedroom,
                    Bathroom = building.Bathroom,
                    Garage = building.Garage,
                    Image = building.Image,
                    State = building.State,
                    City = building.City,
                    Postcode = building.Postcode,
                };
            }
            
            return result;
        }
    }
}
