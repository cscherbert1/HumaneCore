using HumaneCore.Data;
using HumaneCore.Data.Interfaces;
using HumaneCore.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HumaneCore.Service
{
    public class ColorService : IColor
    {
        private readonly ApplicationDbContext _context;
        public ColorService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task Add(Color color)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Color> GetAll()
        {
            try
            {
                return _context.Colors;
            } catch(Exception ex)
            {
                throw ex;
            }
        }

        public Color GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateName(int Id, string newName)
        {
            throw new NotImplementedException();
        }
    }
}
