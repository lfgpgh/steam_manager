using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SteamManager.Core.Utilities
{
    public static class HashHelper
    {
        /// <summary>
        /// Returns a Sha 256 compatable Hex string
        /// </summary>
        /// <param name="value"></param>
        /// <param name="salt"></param>
        /// <returns>Hex string</returns>
        public static string SHA256Hash(string value, string salt)
        {
            var hasher = SHA256.Create();
            var saltedId = string.Format("{0}{1}", value, salt);

            var id = hasher.ComputeHash(Encoding.UTF8.GetBytes(saltedId));


            var result = ByteArrayToString(id);

            return result;
        }
        private static string ByteArrayToString(byte[] ba)
        {
            string hex = BitConverter.ToString(ba);
            return hex.Replace("-", "");
        }
    }
}
