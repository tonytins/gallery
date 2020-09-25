using System.Collections.Generic;

namespace Tonytins.Models
{
    public class CommissionsModel
    {
        public string Country { get; set; }
        public IEnumerable<CommissionInfo> Commisions { get; set; }
    }

    public class CommissionInfo
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Cost { get; set; }
        public decimal Extra { get; set; }
        public IEnumerable<string> Details { get; set; }
        public IEnumerable<string> Examples { get; set; }
        public string Notes { get; set; }
    }
}
