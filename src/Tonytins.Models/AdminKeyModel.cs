using System.ComponentModel.DataAnnotations;

namespace Tonytins.Models
{
    public class AdminKeyModel
    {
        [Required]
        public string Key { get; set; }
    }
}
