namespace FootballManager.Domain.Entities
{
    public class Game : BaseEntity
    {
        public Game()
        {
        }

        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public int Team1Result { get; set; }
        public int Team2Result { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
    }
}
