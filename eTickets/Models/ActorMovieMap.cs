namespace eTickets.Models
{
    public class ActorMovieMap
    {
        public int MovieID { get; set; }
        public Movie Movie { get; set; }
        public int ActorID { get; set; }
        public Actor Actor { get; set; }
    }
}
