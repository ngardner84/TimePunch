using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time2punch
{
    class EncryptPass
    {
        private string pass;

        public EncryptPass(string pw)
        {
            pass = pw;

        }

        /* TBH, I ripped alot of this from the internet.
         * I don't really know how it works,
         * but it works. 
         */

        public static String ByteArrayToHexString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
            {
                hex.AppendFormat("{0:x2}", b);
            }

            return hex.ToString();
        }

        public string GenSaltSHA256()
        {
            String salt = CreateSalt(10);
            String hashedPass = GenerateHash(this.pass, salt);
            return hashedPass;
        }

        private string CreateSalt(int size)
        {
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);

            return Convert.ToBase64String(buff);
        }

        public string GenerateHash(string input, string salt)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input + salt);
            System.Security.Cryptography.SHA256Managed sha256HashString =
                new System.Security.Cryptography.SHA256Managed();

            byte[] hash = sha256HashString.ComputeHash(bytes);

            return ByteArrayToHexString(hash);
        }

    }

}
