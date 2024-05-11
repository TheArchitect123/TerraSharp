﻿using System.Security.Cryptography;
using Terra.Microsoft.Extensions.StringExt;

namespace Terra.Microsoft.Extensions.Security
{
    public class HashExtensions
    {
        public static string GetSha256(string data) => new Plugin.Security.Core.PasswordEncoder()
            .Encode(data, Plugin.Security.Core.EncryptType.SHA_256);

        public static string HashToHex(byte[] data)
        {
            return TerraStringExtensions.GetHexFromString(Sha256(data));
        }


        public static byte[] Sha256(byte[] data)
        {
            using (SHA256 hash = SHA256.Create())
            {
                return hash.ComputeHash((data));
            }
        }

        public static byte[] Ripemd(byte[] data)
        {
            using (RIPEMD160 hash = RIPEMD160.Create())
            {
                return hash.ComputeHash((data));
            }
        }


        private static char ToHexDigit(int i)
        {
            if (i < 10)
                return (char)(i + '0');
            return (char)(i - 10 + 'A');
        }
        public static string ToHexString(byte[] bytes)
        {
            var chars = new char[bytes.Length * 2 + 2];

            chars[0] = '0';
            chars[1] = 'x';

            for (int i = 0; i < bytes.Length; i++)
            {
                chars[2 * i + 2] = ToHexDigit(bytes[i] / 16);
                chars[2 * i + 3] = ToHexDigit(bytes[i] % 16);
            }

            return new string(chars);
        }
    }
}
