using System.Collections.Generic;

namespace Tonytins.Models
{
    /// <summary>
    /// Gallery page
    /// </summary>
    public class GalleryTwoModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<GalleryModel> Artwork { get; set; }
    }
}
