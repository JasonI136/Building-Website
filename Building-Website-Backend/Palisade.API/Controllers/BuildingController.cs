using Microsoft.AspNetCore.Mvc;
using Palisade.Domain.Entity;
using Palisade.Service;
using Palisade.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Palisade.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingController
    {
        IBuildingService _buildingService;

        public BuildingController(IBuildingService buildingService) 
        {
            _buildingService = buildingService;
        }

        [HttpGet("list")]
        public ActionResult<List<Building>> List()
        {

            return _buildingService.List();
        }

        [HttpGet("view/{buildingId}")]
        public ActionResult<BuildingDTO> View(long buildingId)
        {
            return _buildingService.View(buildingId);
        }
    }
}
