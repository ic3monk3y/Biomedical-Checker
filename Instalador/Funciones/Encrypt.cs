using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Instalador.Funciones
{
    class Encrypt
    {
        public string[] DesEncrypt(string db, string usr, string psswrd)
        {
            string[] resultado = new string[3];

            resultado[0] = DesCifrar(db, "Fives2021++");
            resultado[1] = DesCifrar(usr, "Fives2021++");
            resultado[2] = DesCifrar(psswrd, "Fives2021++");

            return resultado;
        }

        public static string DesCifrar(string cadenaString, string claveString)
        {
            string plainText;
            claveString = Hashing256(claveString);
            claveString = claveString.Substring(0, 16);
            byte[] datosCombinados = Convert.FromBase64String(cadenaString);
            Aes aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(claveString);
            //aes.Key = new byte[] { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F };
            byte[] iv = new byte[aes.BlockSize / 8];
            byte[] textoCifrado = new byte[datosCombinados.Length - iv.Length];
            Array.Copy(datosCombinados, iv, iv.Length);
            Array.Copy(datosCombinados, iv.Length, textoCifrado, 0, textoCifrado.Length);
            aes.IV = iv;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform decipher = aes.CreateDecryptor(aes.Key, aes.IV);

            using (MemoryStream ms = new MemoryStream(textoCifrado))
            {
                using (CryptoStream cs = new CryptoStream(ms, decipher, CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(cs))
                    {
                        plainText = sr.ReadToEnd();
                    }
                }

                return plainText;
            }
        }

        //Funcion para convertirlo en un hash de 256 bits y facilitar el manejo de la cadena
        static string Hashing256(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
