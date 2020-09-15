// Anthony Leland licenses this file to you under the MIT license.
using Markdig;
using Microsoft.AspNetCore.Components;

namespace Tonytins.Web
{
    public static class SiteHelper
    {
        /// <summary>
        /// Locates an image relative to it's location in the images directory. This is mostly meant to
        /// aid galleries where the metadata is offloaded to a JSON, for example, and resolved by this function.
        /// </summary>
        /// <param name="image">image itself</param>
        /// <param name="path">path relative to images directory</param>
        /// <returns></returns>
        public static string ResolveImagePath(string image, string path) => @$"../images/{path}/{image}";

        public static string JsonCDN(string json) => $@"https://cdn.tonytins.xyz/db/{json}.json";

        public static string JsonCDN(string json, string path) => $@"https://cdn.tonytins.xyz/db/{path}/{json}.json";

        public static string ImageCDN(string image, string path) => $@"https://cdn.tonytins.xyz/images/{path}/{image}";

        /// <summary>
        /// Converts and sanitizes any Markdown to HTML. If the content
        /// is, for any reason, null or empty it will return a empty string.
        /// </summary>
        /// <param name="content"></param>
        /// <returns>HTML</returns>
        public static MarkupString MarkdownToHtml(this string content)
        {
            if (!string.IsNullOrEmpty(content))
            {
                var pipeline = new MarkdownPipelineBuilder()
                    .DisableHtml()
                    .Build();

                return (MarkupString)Markdown.ToHtml(content, pipeline);
            }
            else
                return (MarkupString)string.Empty;
        }
    }
}
