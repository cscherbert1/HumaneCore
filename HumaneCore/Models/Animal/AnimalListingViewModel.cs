﻿using HumaneCore.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HumaneCore.Models.Animal
{
    public class AnimalListingViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        [DisplayName ("Arrived: ")]
        public DateTime IntakeDate { get; set; }
        public string Bio { get; set; }
        [DisplayName("Spayed or Neutered: ")]
        public bool SpayedNeutered { get; set; }

        public virtual Species Species { get; set; }
        public virtual Breed Breed { get; set; }
        public virtual Color Color { get; set; }
        public IEnumerable<AnimalRestriction> AnimalRestrictions { get; set; }
        public IEnumerable<Media> Media { get; set; }




    }
}
