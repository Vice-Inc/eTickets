using eTickets.Data.Interfaces;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext context;

        public ActorsService(AppDbContext dbContext)
        {
            context = dbContext;
        }

        public async Task AddAsync(Actor actor)
        {
            await context.Actors.AddAsync(actor);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<Actor>> IActorsService.GetAllAsync()
        {
            return await context.Actors.ToListAsync();
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            return await context.Actors.FirstOrDefaultAsync(a => a.id == id);
        }

        public async Task UpdateAsync(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
