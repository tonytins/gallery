// Anthony Leland licenses this file to you under the MIT license.
using System.Runtime.InteropServices;

namespace Tonytins.Web
{
    public struct SiteConsts
    {
        public const string SiteName = "Tonytins";

        public static string Framework => RuntimeInformation.FrameworkDescription;

        public static string SiteVersion =>
            $"{ThisAssembly.Git.SemVer.Major}.{ThisAssembly.Git.SemVer.Minor}.{ThisAssembly.Git.SemVer.Patch}-{ThisAssembly.Git.Commit}";
    }
}
