// Anthony Leland licenses this file to you under the MIT license.
namespace Tonytins.Web.Models
{
    /// <summary>
    /// Basic hero profile with another model
    /// containing the CoH server.
    /// </summary>
    public class HeroModel
    {
        const string TBA = "Coming Soon";

        public string Hero { get; set; } = TBA;

        public string Backstory { get; set; } = TBA;

        public string Image { get; set; } = "../images/brands/coh-card.png";

        public CohServer Server { get; set; }
    }

    public class CohServer
    {
        public string Name { get; set; } = "Example";

        public string Link { get; set; } = "https://example.com";
    }
}
