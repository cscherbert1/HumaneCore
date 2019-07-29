using HumaneCore.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HumaneCore.Data.Interfaces
{
    interface IBreed
    {
        Breed GetById(int Id);
        IEnumerable<Breed> GetAll();

        Task Add(Breed breed);
        Task Delete(int Id);
        Task UpdateName(int Id, string newName);
    }
}
