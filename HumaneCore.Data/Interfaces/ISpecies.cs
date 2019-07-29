using HumaneCore.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HumaneCore.Data.Interfaces
{
    public interface ISpecies
    {
        Species GetById(int Id);
        IEnumerable<Species> GetAll();

        Task Add(Species species);
        Task Delete(int Id);
        Task UpdateCommonName(int Id, string newCommonName);
        Task UpdateAdoptionFee(int Id, double newAdoptionFee);
    }
}
