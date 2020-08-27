// Anthony Leland licenses this file to you under the MIT license.
namespace Tonytins.Web.Models
{
    /// <summary>
    /// Basic hero profile with another model
    /// containing the CoH server.
    /// </summary>
    public class HeroModel
    {
        const string NA = "N/A";
        const string DEFAULT_SERVER = "Freedom";

        public string Hero { get; set; } = "Example Hero";
        public string Origin { get; set; } = NA;
        public string Archetype { get; set; } = NA;
        public string Affilation { get; set; } = NA;
        public string Image { get; set; } = "../images/brands/coh-card.png";
        public string Server { get; set; } = DEFAULT_SERVER;
        public string Shard { get; set; } = DEFAULT_SERVER;
    }
}
