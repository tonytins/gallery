
namespace Tonytins.Web
{
    public static class SiteHelper
    {
        /// <summary>
        /// Locates an image relative to it's location in the images directory. This is mostly meant to
        /// aid galleries where the metadata is offloaded to a JSON, for example, and resolved by this function.
        /// </summary>
        /// <param name="image">image itself</param>
        /// <param name="path">path to image</param>
        /// <returns></returns>
        public static string ResolveImagePath(string image, string path) => @$"../images/{path}/{image}";
    }
}
