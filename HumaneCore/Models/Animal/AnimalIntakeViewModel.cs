using HumaneCore.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HumaneCore.Models.Animal
{
    public class AnimalIntakeViewModel
    {
        public AnimalIntakeViewModel()
        {
            this.AnimalRestrictions = new HashSet<AnimalRestriction>();
            this.Media = new HashSet<Media>();
        }
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
        public DateTime IntakeDate { get; set; }
        public string Bio { get; set; }
        [Required]
        public bool SpayedNeutered { get; set; }

        [Required]
        public int SpeciedId { get; set; }
        public Species Species { get; set; }
        public IEnumerable<Species> SpeciesCollection { get; set; }
        [Required]
        public int BreedId { get; set; }
        public virtual Breed Breed { get; set; }
        public IEnumerable<Breed> BreedCollection { get; set; }
        public int ColorId { get; set; }
        public virtual Color Color { get; set; }
        public IEnumerable<Color> ColorCollection { get; set; }

        /*
         * How to display all restrictions and bind multiple selected?
         * How to upload multiple media files, save them, and associate w/ correct animal?
         */
        public IEnumerable<AnimalRestriction> AnimalRestrictions { get; set; }
        public IEnumerable<int> SelectedRestrictions { get; set; }
        public IEnumerable<Media> Media { get; set; }
        public IEnumerable<string> MediaUrls { get; set; }
    }
}
