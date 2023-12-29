using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllActors();
        Actor GetActorByActorId(int id);
        void AddActor(Actor actor);
        Actor UpdateActor(int Id, Actor actor);
        void DeleteActor(int Id);
    }
}
