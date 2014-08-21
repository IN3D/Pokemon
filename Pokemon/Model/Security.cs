using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Pokemon.Model
{
    public static class Security
    {
        private const int SBS = 24;
        private const int HBS = 24;
        private const int PIT = 1000;
        private const int II = 0;
        private const int SI = 1;
        private const int PI = 2;

        public static string createHash(string p)
        {
            RNGCryptoServiceProvider crng = new RNGCryptoServiceProvider();
            byte[] s = new byte[SBS];
            crng.GetBytes(s);
            byte[] h = PBKDF2(p, s, PIT, HBS);
            return PIT + ":" +
                Convert.ToBase64String(s) + ":" + Convert.ToBase64String(h);
        }

        public static bool validatePassword(string p, string c)
        {
            char[] d = { ':' };
            string[] split = c.Split(d);
            int i  = Int32.Parse(split[II]);
            byte[] s = Convert.FromBase64String(split[SI]);
            byte[] h = Convert.FromBase64String(split[PI]);
            byte[] th = PBKDF2(p, s, i, h.Length);
            return slowEquals(h, th);
        }

        private static bool slowEquals(byte[] a, byte[] b)
        {
            uint diff = (uint)a.Length ^ (uint)b.Length;
            for (int i = 0; i < a.Length && i < b.Length; i++)
                diff |= (uint)(a[i] ^ b[i]);
            return diff == 0;
        }

        private static byte[] PBKDF2(string p, byte[] s, int i, int o)
        {
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(p, s);
            pbkdf2.IterationCount = i;
            return pbkdf2.GetBytes(o);
        }
    }
}
