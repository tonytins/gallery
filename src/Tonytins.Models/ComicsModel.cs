using System;
using System.Collections.Generic;
using System.Text;

namespace Tonytins.Models
{
    public class ComicsModel : ArtworkBase
    {
        public Guid Prev { get; set; }
        public Guid Next { get; set; }
    }
}
