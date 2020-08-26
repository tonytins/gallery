// Anthony Leland licenses this file to you under the MIT license.
namespace Tonytins.Web.Models
{
    /// <summary>
    /// Basic hero profile with another model
    /// containing the CoH server.
    /// </summary>
    public class HeroModel
    {
        public string Hero { get; set; } = "Example Hero";

        public string Backstory { get; set; } = string.Empty;

        public string Image { get; set; } = "../images/brands/coh-card.png";
        public string Server { get; set; } = "Freedom";
        public string Shard { get; set; } = "Freedom";
    }
}
