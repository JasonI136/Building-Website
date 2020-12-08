using System;
using System.Collections.Generic;

#nullable disable

namespace BuildingAdmin.Domain.Entity
{
    public partial class User
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime? Dob { get; set; }
        public string PhoneNumber { get; set; }
        public bool? IsSuccess { get; set; }
        public string Messages { get; set; }
    }
}
