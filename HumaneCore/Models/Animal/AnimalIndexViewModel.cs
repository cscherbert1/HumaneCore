using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumaneCore.Models.Animal
{
    public class AnimalIndexViewModel
    {
        public IEnumerable<AnimalListingViewModel> AnimalList { get; set; }
    }
}
