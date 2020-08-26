// Anthony Leland licenses this file to you under the MIT license.
namespace Tonytins.Web.Models
{
    /// <summary>
    /// Basic hero profile with another model
    /// containing the CoH server.
    /// </summary>
    public class HeroModel
    {
        public string Hero { get; set; } = "Lorem ipsum";

        public string Backstory { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et condimentum sem. Curabitur et congue leo. In.";

        public string Image { get; set; } = "../images/brands/coh-card.png";
        public string Server { get; set; } = "Freedom";
    }
}
