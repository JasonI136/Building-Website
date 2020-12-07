using Microsoft.AspNetCore.Mvc;
using Palisade.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Palisade.Shared.DTO;

namespace Palisade.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        IContactUsService _contactUsService;
        public ContactController(IContactUsService contactUsService) {
            _contactUsService = contactUsService;
        }

        [HttpPost("sendMessage")]
        public ActionResult<ContactUsDTO> SendMessage([FromBody] ContactUsDTO contactUsDTO) 
        {
            return _contactUsService.SendMessage(contactUsDTO);
        }
    }
}
