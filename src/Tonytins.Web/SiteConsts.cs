// Anthony Leland licenses this file to you under the MIT license.
namespace Tonytins.Web
{
    public struct SiteConsts
    {
        public const string SiteName = "Tonytins";

        public static string SiteVersion => $"{ThisAssembly.Git.SemVer.Major}.{ThisAssembly.Git.SemVer.Minor}.{ThisAssembly.Git.SemVer.Patch}-{ThisAssembly.Git.Commit}";
    }
}
