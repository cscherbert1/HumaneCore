using HumaneCore.Data;
using HumaneCore.Data.Interfaces;
using HumaneCore.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneCore.Service
{
    public class SpeciesService : ISpecies
    {
        private readonly ApplicationDbContext _context;
        public SpeciesService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task Add(Species species)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Species> GetAll()
        {
            throw new NotImplementedException();
        }

        public Species GetById(int Id)
        {
            return _context.Species.Where(s => s.Id == Id)
                .Include(s => s.Breeds)
                .Include(s => s.Animals)
                .FirstOrDefault();
        }

        public Task UpdateAdoptionFee(int Id, double newAdoptionFee)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCommonName(int Id, string newCommonName)
        {
            throw new NotImplementedException();
        }
    }
}
