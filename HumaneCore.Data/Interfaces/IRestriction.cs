using HumaneCore.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HumaneCore.Data.Interfaces
{
    public interface IRestriction
    {
        Restriction GetById(int Id);
        IEnumerable<Restriction> GetAll();

        Task Add(Restriction restriction);
        Task Delete(int Id);
        Task UpdateDescription(int Id, string newDescription);
    }
}
