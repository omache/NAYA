using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace HopeForHumanity
{
    public class EncDec
    {
        private static TripleDES CreateDES(string key)
        {
            TripleDES edes = new TripleDESCryptoServiceProvider();
            MD5 md = new MD5CryptoServiceProvider();
            return new TripleDESCryptoServiceProvider { Key = md.ComputeHash(Encoding.Unicode.GetBytes(key)), IV = new byte[edes.BlockSize / 8] };
        }

        public static string Decryption(string Base64CypherText, string key)
        {
            byte[] inputBuffer = Convert.FromBase64String(Base64CypherText);
            byte[] bytes = CreateDES(key).CreateDecryptor().TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
            return Encoding.Unicode.GetString(bytes);
        }

        public static byte[] Encryption(string PlainText, string key)
        {
            ICryptoTransform transform = CreateDES(key).CreateEncryptor();
            byte[] bytes = Encoding.Unicode.GetBytes(PlainText);
            return transform.TransformFinalBlock(bytes, 0, bytes.Length);
        }

        //SHA256
        public static string SHAEncrypt(string toEncrypt)
        {
            SHA256Managed crypt = new SHA256Managed();
            StringBuilder hash = new StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(toEncrypt), 0, Encoding.UTF8.GetByteCount(toEncrypt));
            return ByteToHex(crypto);
        }
        //Byte to String
        public static string ByteToString(byte[] buff)
        {
            string sbinary = "";

            for (int i = 0; i < buff.Length; i++)
            {
                sbinary += buff[i].ToString("X2"); // hex format
            }
            return (sbinary);
        }
        //Byte to Hex
        public static string ByteToHex(byte[] myByteArray)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in myByteArray)
                sb.Append(b.ToString("X2"));
            return sb.ToString();
        }
    }
}