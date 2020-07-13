namespace FootballManager.Infrastructure.ViewModel
{
    public class GameModel
    {
        public int GameId { get; set; }
        public int Team1Id { get; set; }
        public int Team2Id { get; set; }
        public int Team1Result { get; set; }
        public int Team2Result { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
    }
}
