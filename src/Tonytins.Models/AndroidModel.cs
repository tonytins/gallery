using System.Collections.Generic;

namespace Tonytins.Models
{
    public class AndroidModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<AndroidCharsModel> Characters { get; set; }
    }

    public class AndroidCharsModel
    {
        public string Name { get; set; }
        public string Permalink { get; set; }
    }
}
