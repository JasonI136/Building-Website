using Palisade.Interface.Domain;
using Palisade.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Palisade.Service
{
    public class ContactUsService : IContactUsService
    {
        IRepository _repository;
        public ContactUsService(IRepository repository)
        {
            _repository = repository;
        }

        public ContactUsDTO SendMessage(ContactUsDTO contactUsDTO)
        {
            return contactUsDTO;
        }
    }
}
