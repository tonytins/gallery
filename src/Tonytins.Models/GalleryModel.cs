using System.Collections.Generic;

namespace Tonytins.Models
{
    /// <summary>
    /// Gallery page
    /// </summary>
    public class GalleryModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<ArtworkModel> Artwork { get; set; }
    }
}
