using System.Collections.Generic;
using HumaneCore.Data.Models;
using HumaneCore.Models.Animal;

namespace HumaneCore.Models.Animal
{
    public class AnimalSpeciesViewModel
    {
        public Species Species { get; set; }
        public IEnumerable<AnimalListingViewModel> AnimalList { get; set; }
    }
}