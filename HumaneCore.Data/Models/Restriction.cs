using System;
using System.Collections.Generic;
using System.Text;

namespace HumaneCore.Data.Models
{
    public class Restriction
    {
        public Restriction()
        {
            this.AnimalRestrictions = new HashSet<AnimalRestriction>();
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public IEnumerable<AnimalRestriction> AnimalRestrictions { get; }

    }
}
