using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDades
{
    public class Encrypt
    {
        private int byteSize;
        private int saltSize;
        private int iterations;

        public Encrypt()
        {
            byteSize = 24;
            saltSize = 24;
            iterations = 30000;
        }

        public byte[] ToBytes(string text)
        {
            return Convert.FromBase64String(text);
        }

        public string ToString(byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }

        public byte[] Hash
        (string password, byte[] salt)
        {
            Rfc2898DeriveBytes hashGenerator = new Rfc2898DeriveBytes(password, salt);
            hashGenerator.IterationCount = iterations;
            return hashGenerator.GetBytes(byteSize);
        }

        public byte[] Sal()
        {
            RNGCryptoServiceProvider saltGenerator = new RNGCryptoServiceProvider();
            byte[] sal = new byte[saltSize];
            saltGenerator.GetBytes(sal);
            return sal;
        }

        public bool VerificarPass
        (string password, byte[] passwordSal, byte[] passwordHash)
        {
            byte[] computedHash = Hash(password, passwordSal);
            return HashesIguales(computedHash, passwordHash);
        }

        public bool HashesIguales(byte[] hash1, byte[] hash2)
        {
            int minHashLenght = hash1.Length <= hash2.Length ?
            hash1.Length : hash2.Length;

            var xor = hash1.Length ^ hash2.Length;
            for (int i = 0; i < minHashLenght; i++)
                xor |= hash1[i] ^ hash2[i];
            return 0 == xor;
        }
    }
}
