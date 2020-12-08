using System;
using System.Collections.Generic;

#nullable disable

namespace BuildingAdmin.Domain.Entity
{
    public partial class ContactUsForm
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public string TextArea { get; set; }
        public DateTime? Datetime { get; set; }
    }
}
