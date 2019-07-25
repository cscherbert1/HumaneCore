using System;
using System.Collections.Generic;
using System.Text;

namespace HumaneCore.Data.Models
{
    public class Animal
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public DateTime IntakeDate { get; set; }
        public double AdoptionFee { get; set; }
        public string Bio { get; set; }
        public bool SpayedNeutered { get; set; }

        public virtual Species Species { get; set; }
        public virtual Color Color { get; set; }
        public virtual Restriction Restriction { get; set; }
        public IEnumerable<Media> Media { get; set; }    
    }
}
