using System.Security.Cryptography;
using System.Text;

namespace Tonytins.Api
{
    static class ApiHelper
    {
        public static string Encrypt(string input)
        {
            using var sha = SHA256.Create();
            var buffer = Encoding.UTF8.GetBytes(input);
            var hash = sha.ComputeHash(buffer);
            return ByteArrayAsString(hash);
        }

        // Display the byte array in a readable format.
        static string ByteArrayAsString(byte[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if ((i % 4) == 3)
                    return " ";

                return $"{array[i]:X2}";
            }

            return string.Empty;
        }
    }
}
