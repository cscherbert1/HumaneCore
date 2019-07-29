using System;
using System.Collections.Generic;
using System.Text;

namespace HumaneCore.Data.Models
{
    public class Species
    {
        public Species()
        {
            this.Breeds = new HashSet<Breed>();
            this.Animals = new HashSet<Animal>();
        }
        public int Id { get; set; }
        public string CommonName { get; set; }
        public double AdoptionFee { get; set; }

        public IEnumerable<Breed> Breeds { get; set; }
        public IEnumerable<Animal>Animals { get; set; }
    }
}
