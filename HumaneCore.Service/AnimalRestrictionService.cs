using HumaneCore.Data;
using HumaneCore.Data.Interfaces;
using HumaneCore.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HumaneCore.Service
{
    public class AnimalRestrictionService : IAnimalRestriction
    {
        private readonly ApplicationDbContext _context;
        public AnimalRestrictionService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task Add(AnimalRestriction animalRestriction)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AnimalRestriction> GetAll()
        {
            try
            {
                return _context.AnimalRestrictions
                    .Include(ar => ar.Animal)
                    .Include(ar => ar.Restriction);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public AnimalRestriction GetById(int AnimalId, int RestrictionId)
        {
            throw new NotImplementedException();
        }
    }
}
