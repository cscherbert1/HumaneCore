using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HumaneCore.Data;
using HumaneCore.Data.Interfaces;
using HumaneCore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HumaneCore.Service
{
    public class AnimalService : IAnimal
    {
        private readonly ApplicationDbContext _context;
        public AnimalService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task Create(Animal animal)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Animal> GetAll()
        {
            return _context.Animals
                .Include(a => a.Species).ThenInclude(a => a.Breeds)
                .Include(a => a.AnimalRestrictions)
                .Include(a => a.Color);
        }

        public Animal GetById(Guid Id)
        {
            return _context.Animals.Find(Id);
        }

        public IEnumerable<Animal> GetBySpecies(int speciesId)
        {
            return _context.Species.Find(speciesId).Animals;
        }

        public Task Update(Animal animal)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAge(Guid id, int newAge)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBio(Guid id, string newBio)
        {
            throw new NotImplementedException();
        }

        public Task UpdateName(Guid id, string newName)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSpayNeut(Guid id, bool newSpayedNeutered)
        {
            throw new NotImplementedException();
        }
    }
}
