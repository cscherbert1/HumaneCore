using System;
using System.Collections.Generic;
using System.Text;

namespace HumaneCore.Data.Models
{
    public class Animal
    {
        public Animal()
        {
            this.AnimalRestrictions = new HashSet<AnimalRestriction>();
            this.Media = new HashSet<Media>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public DateTime IntakeDate { get; set; }
        public string Bio { get; set; }
        public bool SpayedNeutered { get; set; }

        public virtual Species Species { get; set; }
        public virtual Breed Breed { get; set; }
        public virtual Color Color { get; set; }
        public IEnumerable<AnimalRestriction> AnimalRestrictions { get; }
        public IEnumerable<Media> Media { get; set; }    
    }
}
