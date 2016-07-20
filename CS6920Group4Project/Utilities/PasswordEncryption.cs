using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace CS6920Group4Project.Utilities
{
    public static class PasswordEncryption
    {

        private const int SALT_BYTE_SIZE    = 24;
        private const int HASH_BYTE_SIZE    = 24;
        private const int PBKDF2_ITERATIONS = 1000;
        private const int ITERATION_INDEX   = 0;
        private const int SALT_INDEX        = 1;
        private const int PBKDF2_INDEX      = 2;

        public static string CreateHash(string password)
        {
            byte[] salt = new byte[SALT_BYTE_SIZE];
            using (RNGCryptoServiceProvider csprng = new RNGCryptoServiceProvider())
            {
                csprng.GetBytes(salt);
            }
            byte[] hash = PBKDF2(password, salt, PBKDF2_ITERATIONS, HASH_BYTE_SIZE);
            return PBKDF2_ITERATIONS + ":" + Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
        }

        private static byte[] PBKDF2(string password, byte[] salt, int iterations, int outputBytes)
        {
            using (Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt))
            {
                pbkdf2.IterationCount = iterations;
                return pbkdf2.GetBytes(outputBytes);
            }
        }

        private static bool SlowEquals(IList<byte> a, IList<byte> b)
        {
            var diff = (uint)a.Count ^ (uint)b.Count;

            for (var i = 0; (i < a.Count) && (i < b.Count); i++)
            {
                diff |= (uint)(a[i] ^ b[i]);
            }

            return diff == 0;
        }

        public static bool ValidatePassword(string password, string correctHash)
        {
            // Extract the parameters from the hash
            var delimiter = new[] { ':' };
            var split = correctHash.Split(delimiter);
            var iterations = int.Parse(split[ITERATION_INDEX]);
            var salt = Convert.FromBase64String(split[SALT_INDEX]);
            var hash = Convert.FromBase64String(split[PBKDF2_INDEX]);
            var testHash = PBKDF2(password, salt, iterations, hash.Length);
            return SlowEquals(hash, testHash);
        }
    }
}
