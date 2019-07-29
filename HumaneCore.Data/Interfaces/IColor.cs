using HumaneCore.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HumaneCore.Data.Interfaces
{
    public interface IColor
    {
        Color GetById(int Id);
        IEnumerable<Color> GetAll();

        Task Add(Color color);
        Task Delete(int Id);
        Task UpdateName(int Id, string newName);
    }
}
