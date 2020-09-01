// Anthony Leland licenses this file to you under the MIT license.

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
        /*
        public static Uri HyperToHttp(string address)
        {
            if (IsHyperProtocol(address))
                return new Uri(address.Replace("hyper", "https"));

            if (address.Contains("dat"))
                return new Uri(address.Replace("dat", "https"));

            return new Uri(address);
        }

        public static bool IsHyperProtocol(string address)
        {
            if (address.Contains("hyper"))
                return true;

            return false;
        }

        public static string HttpToHyper(string address)
        {
            if (address.Contains("http"))
                return address.Replace("http", "hyper");

            return address.Replace("https", "hyper");
        } */
    }
}
