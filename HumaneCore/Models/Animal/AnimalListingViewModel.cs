using HumaneCore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumaneCore.Models.Animal
{
    public class AnimalListingViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public virtual Species Species { get; set; }
        public virtual Color Color { get; set; }
        public virtual Restriction Restriction { get; set; }
        public IEnumerable<Media> Media { get; set; }
    }
}
