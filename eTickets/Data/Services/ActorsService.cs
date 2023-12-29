using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddActor(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public void DeleteActor(int Id)
        {
            throw new NotImplementedException();
        }

        public Actor GetActorByActorId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAllActors()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public Actor UpdateActor(int Id, Actor actor)
        {
            throw new NotImplementedException();
        }
    }
}
