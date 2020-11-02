using System.Collections.Generic;

namespace Tonytins.Models
{
    /// <summary>
    /// Gallery page
    /// </summary>
    public class GalleryBase<T> where T : class
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<T> Gallery { get; set; }
    }
}
