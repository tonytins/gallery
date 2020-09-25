using System.Collections.Generic;

namespace Tonytins.Models.Gallery
{
    /// <summary>
    /// Gallery page
    /// </summary>
    public class GalleryModel<T> where T : class
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<T> Artwork { get; set; }
    }
}
