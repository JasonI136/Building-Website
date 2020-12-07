using System;
using System.Collections.Generic;
using System.Text;

namespace Palisade.Shared.DTO
{
    public class ContactUsDTO
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public string TextArea { get; set; }
        public DateTime? Datetime { get; set; }
    }
}
