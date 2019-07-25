using System;
using System.Collections.Generic;
using System.Text;

namespace HumaneCore.Data.Models
{
    public class Media
    {
        public long Id { get; set; }
        public string Location { get; set; }

        public virtual MediaType MediaType { get; set; }
    }
}
