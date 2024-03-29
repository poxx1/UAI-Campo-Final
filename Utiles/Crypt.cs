﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Utiles
{
    public class Crypt
    {
        public string MD5Gen(string secret)
        {
            UnicodeEncoding code = new UnicodeEncoding();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] ByteS = code.GetBytes(secret);
            byte[] Hash = md5.ComputeHash(ByteS);

            return Hash.ToString();
        }

        public string Encrypt(string secret)
        {
            string key = "AmelieLens";
            byte[] keyArray;
            byte[] encode = UTF8Encoding.UTF8.GetBytes(secret);

            try
            {
                var md5 = new MD5CryptoServiceProvider();
                var tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();

                keyArray = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                md5.Clear();

                tripleDESCryptoServiceProvider.Key = keyArray;
                tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
                tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
                ICryptoTransform encriptor = tripleDESCryptoServiceProvider.CreateEncryptor();
                byte[] result = encriptor.TransformFinalBlock(encode, 0, encode.Length);
                tripleDESCryptoServiceProvider.Clear();

                secret = Convert.ToBase64String(result, 0, result.Length);
            }
            catch (Exception)
            {
                throw;
            }

            return secret;
        }

        public string Decrypt(string secret)
        {
            string key = "AmelieLens";

            try
            {
                byte[] keyArray;
                byte[] decode = Convert.FromBase64String(secret);

                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();

                keyArray = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                md5.Clear();

                tripleDESCryptoServiceProvider.Key = keyArray;
                tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
                tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;

                ICryptoTransform decriptor = tripleDESCryptoServiceProvider.CreateDecryptor();
                byte[] resultado = decriptor.TransformFinalBlock(decode, 0, decode.Length);
                tripleDESCryptoServiceProvider.Clear();

                secret = UTF8Encoding.UTF8.GetString(resultado);
            }
            catch (Exception)
            {
                throw;
            }

            return secret;
        }

        public string ToBase64String(Bitmap bitmap)
        {
            Bitmap bmp = bitmap;
           
            string base64ImageString = bmp.ToString();

            //Bitmap bmpFromString = base64ImageString.Base64StringToBitmap();
            //bmpFromString.Save("FromBase64String.png",ImageFormat.Png);

            return base64ImageString;
        }

        public Bitmap ToBitmap(string base64string)
        {
            return new Bitmap(base64string);
        }
    }
}