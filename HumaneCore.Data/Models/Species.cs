using System;
using System.Collections.Generic;
using System.Text;

namespace HumaneCore.Data.Models
{
    public class Species
    {
        public int Id { get; set; }
        public string CommonName { get; set; }

        public virtual Breed Breed { get; set; }
    }
}
