using System.Collections.Generic;

namespace FootballManager.Domain.Entities
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
    }
}
