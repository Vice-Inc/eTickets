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

        public void Add(Actor actor)
        {
            context.Actors.Add(actor);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<Actor>> IActorsService.GetAll()
        {
            return await context.Actors.ToListAsync();
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
