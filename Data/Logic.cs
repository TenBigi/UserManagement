using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Drawing.Text;

namespace UserManagemet.Data
{
    internal class Logic
    {
        public static List<User> Users { get; set; } = new List<User>();

        private string GetFilePath(string file)
        {
            return Path.Combine("../../../data", file);
        }

        public byte[] Key { get; private set; }
        public byte[] IV { get; private set; }

        public byte[] getEncryptedPasswd(string passwd)
        {
            byte[] encrypted;
            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;
                encrypted = EncryptStringToBytes(passwd, aes.Key, aes.IV);
                return encrypted;
            } 
        }

        public string getDecryptedPasswd(byte[] passwd)
        {
            string decrypted;
            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;
                decrypted = DecryptStringFromBytes(passwd, aes.Key, aes.IV);
                return decrypted;
            }
        }

        public byte[] LoadOrGenerateKey()
        {
            string keyFilePath = GetFilePath("aesKey.bin");

            if (File.Exists(keyFilePath))
            {
                Key = File.ReadAllBytes(keyFilePath);
            }
            else
            {
                Key = GenerateRandomBytes(32);
                File.WriteAllBytes(keyFilePath, Key);
            }
            return Key;
        }

        public byte[] LoadOrGenerateIV()
        {
            string ivFilePath = GetFilePath("aesIV.bin");

            if (File.Exists(ivFilePath))
            {
                IV = File.ReadAllBytes(ivFilePath);
            }
            else
            {
                IV = GenerateRandomBytes(16);
                File.WriteAllBytes(ivFilePath, IV);
            }
            return IV;
        }   

        private byte[] GenerateRandomBytes(int length)
        {
            byte[] randomBytes = new byte[length];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(randomBytes);
            }
            return randomBytes;
        }   

        private byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
        {
            byte[] encrypted;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, aesAlg.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return encrypted;
        }

        private string DecryptStringFromBytes(byte[] text, byte[] key, byte[] iv)
        {
            string decrypted;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                using (MemoryStream msDecrypt = new MemoryStream(text))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, aesAlg.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            decrypted = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return decrypted;
        }

        public Logic()
        {
            Key = LoadOrGenerateKey();
            IV = LoadOrGenerateIV();
        }

        public Logic(byte[] key, byte[] iV)
        {
            Key = key;
            IV = iV;
        }
    }
}
