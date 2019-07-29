using System;
using System.Collections.Generic;
using System.Text;

namespace HumaneCore.Data.Models
{
    public class AnimalRestriction
    {
        public long AnimalId { get; set; }
        public Animal Animal { get; set; }
        public int RestrictionId { get; set; }
        public Restriction Restriction { get; set; }
    }
}
