using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllActors();
        Task<Actor> GetActorByActorId(int id);
        Task AddActor(Actor actor);
        Task<Actor> UpdateActor(int Id, Actor actor);
        Task DeleteActor(int Id);
    }
}
