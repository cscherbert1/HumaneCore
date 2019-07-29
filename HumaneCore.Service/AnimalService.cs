using System;
using System.Collections.Generic;
using System.Linq;
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

        public Task Delete(long id)
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

        public Animal GetById(long Id)
        {
            return _context.Animals.Where(a => a.Id == Id)
                .Include(a => a.Species).ThenInclude(a => a.Breeds)
                .Include(a => a.AnimalRestrictions)
                .Include(a => a.Color)
                .Include(a => a.Media)
                .FirstOrDefault();
        }

        public IEnumerable<Animal> GetBySpecies(int speciesId)
        {
            return _context.Species.Find(speciesId).Animals;
        }

        public Task Update(Animal animal)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAge(long id, int newAge)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBio(long id, string newBio)
        {
            throw new NotImplementedException();
        }

        public Task UpdateName(long id, string newName)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSpayNeut(long id, bool newSpayedNeutered)
        {
            throw new NotImplementedException();
        }
    }
}
