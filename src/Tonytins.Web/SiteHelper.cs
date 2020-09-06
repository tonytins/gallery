// Anthony Leland licenses this file to you under the MIT license.
using System;
using Ganss.XSS;
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

        public static string ImageCDN(string image, string path) => $@"https://cdn.tonytins.xyz/images/{path}/{image}";

        public static MarkupString MarkdownToHtml(this string content)
        {
            try
            {
                var pipeline = new MarkdownPipelineBuilder()
                    .DisableHtml()
                    .Build();

                return (MarkupString)Markdown.ToHtml(content, pipeline);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"{ex.StackTrace}{Environment.NewLine}{ex.Message}");
                var santize = new HtmlSanitizer();
                return (MarkupString)santize.Sanitize(content);
            }

        }
    }
}
