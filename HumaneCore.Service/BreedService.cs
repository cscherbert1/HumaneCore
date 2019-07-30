using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HumaneCore.Data;
using HumaneCore.Data.Interfaces;
using HumaneCore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HumaneCore.Service
{
    public class BreedService : IBreed
    {
        private readonly ApplicationDbContext _context;
        public BreedService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task Add(Breed breed)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Breed> GetAll()
        {
            try
            {
                return _context.Breeds;
            } catch(Exception ex)
            {
                throw ex;
            }
        }

        public Breed GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateName(int Id, string newName)
        {
            throw new NotImplementedException();
        }
    }
}
