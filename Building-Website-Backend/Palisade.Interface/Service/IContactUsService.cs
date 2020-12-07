using Palisade.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Palisade.Service
{
    public interface IContactUsService
    {
        ContactUsDTO SendMessage(ContactUsDTO contactUsDTO);
    }
}
