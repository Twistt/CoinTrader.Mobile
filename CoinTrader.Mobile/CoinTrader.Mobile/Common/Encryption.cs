using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CoinTrader.Mobile.Common
{
    public class Encryption
    {
        private static readonly Encoding encoding = Encoding.UTF8;

        public static string Encrypt(string message, string key)
        {
            var keyByte = encoding.GetBytes(key);
            using (var hmacsha512 = new HMACSHA512(keyByte))
            {
                hmacsha512.ComputeHash(encoding.GetBytes(message));

                return ByteToString(hmacsha512.Hash);
            }
        }
        public static string ByteToString(byte[] buff)
        {
            string sbinary = "";
            for (int i = 0; i < buff.Length; i++)
                sbinary += buff[i].ToString("X2"); /* hex format */
            return sbinary;
        }
    }
}
