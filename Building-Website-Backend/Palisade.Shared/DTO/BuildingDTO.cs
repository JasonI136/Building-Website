using System;
using System.Collections.Generic;
using System.Text;

namespace Palisade.Shared.DTO
{
    public class BuildingDTO
    {
        public long Id { get; set; }
        public string BuildingName { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string StreetNumber { get; set; }
        public double? Price { get; set; }
        public string DisplayPrice { get; set; }
        public string Description { get; set; }
        public int? Bedroom { get; set; }
        public int? Bathroom { get; set; }
        public int? Garage { get; set; }
        public string Image { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
    }
}
