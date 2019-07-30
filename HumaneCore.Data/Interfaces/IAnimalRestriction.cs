using HumaneCore.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HumaneCore.Data.Interfaces
{
    public interface IAnimalRestriction
    {
        AnimalRestriction GetById(int AnimalId, int RestrictionId);
        IEnumerable<AnimalRestriction> GetAll();

        Task Add(AnimalRestriction animalRestriction);
        Task Delete(int Id);
    }
}
