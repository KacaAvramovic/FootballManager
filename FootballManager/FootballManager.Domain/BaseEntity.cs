using System.ComponentModel.DataAnnotations;

namespace FootballManager.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
