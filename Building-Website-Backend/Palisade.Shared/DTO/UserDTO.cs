using System;
using System.Collections.Generic;
using System.Text;

namespace Palisade.Shared.DTO
{
    public class UserDTO
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime? Dob { get; set; }
        public string PhoneNumber { get; set; }
        public bool isSuccess { get; set; }
        public List<string> Messages { get; set; }
    }
}
