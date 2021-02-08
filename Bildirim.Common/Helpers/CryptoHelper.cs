using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace Bildirim.Common.Helpers
{
    public class CryptoHelper
    {
        /// <summary>
        /// Girilen string değerini md5 ile şifreleyip döndürür
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string ConvertToMd5(string password)
        {
            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
            byte[] bs = Encoding.UTF8.GetBytes(password);
            bs = x.ComputeHash(bs);
            StringBuilder s = new StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            return s.ToString();
        }

        /// <summary>
        /// Encrypt text using hashkey(optional)
        /// </summary>
        /// <param name="toEncrypt">Metin</param>
        /// <param name="useHashing">hashkeyDurumu</param>
        /// <returns>string</returns>
        public static string Encrypt(string toEncrypt, bool useHashing)
        {
            string hashKey = "ytbHashKey123ytbHashKey1";
            string str = "";
            try
            {
                byte[] keyArray;
                byte[] toEncryptArray = Encoding.UTF8.GetBytes(toEncrypt);

                //If hashing use get hashcode regards to your key
                if (useHashing)
                {
                    MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                    keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(hashKey));
                    //Always release the resources and flush data
                    // of the Cryptographic service provide. Best Practice

                    hashmd5.Clear();
                }
                else
                    keyArray = Encoding.UTF8.GetBytes(hashKey);

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                //set the secret key for the tripleDES algorithm
                tdes.Key = keyArray;
                //mode of operation. there are other 4 modes.
                //We choose ECB(Electronic code Book)
                tdes.Mode = CipherMode.ECB;
                //padding mode(if any extra byte added)

                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateEncryptor();
                //transform the specified region of bytes array to resultArray
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                //Release resources held by TripleDes Encryptor
                tdes.Clear();
                //Return the encrypted data into unreadable string format
                str = Convert.ToBase64String(resultArray, 0, resultArray.Length);
            }
            catch { }
            return str;
        }

        /// <summary>
        /// Decrypt text using hashkey(optional)
        /// </summary>
        /// <param name="cipherString">Metin</param>
        /// <param name="useHashing">hashkeyDurumu</param>
        /// <returns>string</returns>
        public static string Decrypt(string cipherString, bool useHashing)
        {
            string hashKey = "ytbHashKey123ytbHashKey1";
            string str = "";
            try
            {
                byte[] keyArray;
                //get the byte code of the string

                byte[] toEncryptArray = Convert.FromBase64String(cipherString.Replace(" ", "+"));

                if (useHashing)
                {
                    //if hashing was used get the hash code with regards to your key
                    MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                    keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(hashKey));
                    //release any resource held by the MD5CryptoServiceProvider

                    hashmd5.Clear();
                }
                else
                {
                    //if hashing was not implemented get the byte code of the key
                    keyArray = Encoding.UTF8.GetBytes(hashKey);
                }

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                //set the secret key for the tripleDES algorithm
                tdes.Key = keyArray;
                //mode of operation. there are other 4 modes.
                //We choose ECB(Electronic code Book)

                tdes.Mode = CipherMode.ECB;
                //padding mode(if any extra byte added)
                tdes.Padding = PaddingMode.PKCS7;

                System.Security.Cryptography.ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(
                    toEncryptArray, 0, toEncryptArray.Length);
                //Release resources held by TripleDes Encryptor
                tdes.Clear();
                //return the Clear decrypted TEXT
                str = Encoding.UTF8.GetString(resultArray);
            }
            catch (Exception) { }
            return str;
        }

        private static readonly byte[] Vector = { 5, 175, 240, 68, 75, 126, 45, 104, 228, 79, 31, 17, 43, 108, 252, 65, 5, 175, 240, 68, 75, 126, 45, 104, 228, 79, 31, 17, 43, 108, 252, 65 };

        public static string PortableEncrypt(string data, string passphrase, string nonce)
        {
            var bytes = Encoding.UTF8.GetBytes(data);

            bytes = EncryptData(bytes, passphrase);

            var nonceBytes = Encoding.UTF8.GetBytes(nonce);

            var withNonce = new byte[bytes.Length + nonceBytes.Length];
            Array.Copy(nonceBytes, 0, withNonce, 0, nonceBytes.Length);
            Array.Copy(bytes, 0, withNonce, nonceBytes.Length, bytes.Length);

            bytes = EncryptData(withNonce, passphrase);

            var base64 = Convert.ToBase64String(bytes);

            var urlEncoded = HttpUtility.UrlEncode(base64);

            return urlEncoded;
        }

        public static byte[] EncryptData(byte[] data, string passphrase)
        {
            var key = Hash256(passphrase);

            using (var rijndaelManaged = new RijndaelManaged() { Key = key, BlockSize = 256, IV = Vector, Padding = PaddingMode.Zeros, FeedbackSize = 256 })
            using (var memoryStream = new MemoryStream())
            using (var cryptoStream = new CryptoStream(
                                    memoryStream,
                    rijndaelManaged.CreateEncryptor(key, Vector),
                    CryptoStreamMode.Write))
            {
                cryptoStream.Write(data, 0, data.Length);
                cryptoStream.FlushFinalBlock();

                var ret = memoryStream.ToArray();
                return ret;
            }
        }

        private static byte[] Hash256(string data)
        {
            /* Generate key for Rijndael. */

            byte[] bytes = Encoding.UTF8.GetBytes(data);
            byte[] result;

            using (SHA256 shaM = new SHA256Managed())
            {
                result = shaM.ComputeHash(bytes);
            }

            return result;
        }

        public static bool CheckPasswordStrong(string password)
        {
            if (password.Length < 6)
                return false;

            if (password.Length > 15)
                return false;

            if (!Regex.IsMatch(password, @"([a-zA-Z][^\s])+"))
                return false;

            if (!Regex.IsMatch(password, @"[0-9][^\s]+"))
                return false;

            return true;
        }
    }
}
