using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.ComponentModel;

namespace ArshiaDev.Core.Classes
{
    public class HashGenarator
    {
        public static string MD5(string password)
        {
            Byte[] mainByte;
            Byte[] encodeByte;

            MD5 md5 = new MD5CryptoServiceProvider();

            mainByte = ASCIIEncoding.Default.GetBytes(password);
            encodeByte = md5.ComputeHash(mainByte);

            return BitConverter.ToString(encodeByte);
        }
    }
}
