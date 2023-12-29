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

        public async Task AddActor(Actor actor)
        {
            _context.Actors.Add(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteActor(int Id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(x => x.ActorID == Id);
            if (result != null)
            {
                _context.Actors.Remove(result);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<Actor> GetActorByActorId(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(x => x.ActorID == id);
            return result;
        }

        public async Task<IEnumerable<Actor>> GetAllActors()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> UpdateActor(int Id, Actor actor)
        {
            _context.Update(actor);
            await _context.SaveChangesAsync();
            return actor;
        }
    }
}
