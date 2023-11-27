using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FivesCheckerMD.Function
{
    class ConfigINI
    {
        #region Librerias

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileInt(String Section, String Key, int Value, String FilePath);
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(String Section, String Key, String Value, String FilePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileInt(String Section, String Key, int Default, String FilePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(String Section, String Key, String Default, StringBuilder retVal, int Size, String FilePath);

        #endregion Librerias
        public string vIniFile;
        #region Constructores
        public ConfigINI()
        {
            vIniFile = "C:\\FivesChecker\\Data\\config.ini"; ;
        }
        public ConfigINI(string IniFile)
        {
            vIniFile = IniFile;
        }

        #endregion Constructores

        #region Metodos

        public void validarArchivoINI()
        {
            string fileName = "C:\\FivesChecker\\Data\\config.ini"; ;
            FileInfo fi = new FileInfo(fileName);

            try
            {
                if (!fi.Exists)
                {
                    string conf = "[CONFDB]" +
                                    Environment.NewLine +
                                    "USER=" +
                                    Environment.NewLine +
                                    "PASS=" +
                                    Environment.NewLine +
                                    "FTP=192.168.15.32";

                    using (FileStream fs = fi.Create())
                    {

                        Byte[] body = new UTF8Encoding(true).GetBytes(conf);
                        fs.Write(body, 0, body.Length);

                    }
                }

            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

        }

        public String ReadString(String Section, String Key, String Default)
        {
            try
            {
                StringBuilder oStrBu = new StringBuilder(255);
                GetPrivateProfileString(Section, Key, Default, oStrBu, 255, vIniFile);
                // REGRESAMOS EL VALOR OBTENIDO
                return oStrBu.ToString();
            }
            catch (Exception e)
            {
                // MessageBox.Show(e.Message);
                Console.WriteLine(e.Message);
                return "Error: " + e.Message;
                throw;
            }
        }

        public int ReadInt(String Section, String Key, int Default)
        {
            try
            {
                // RETORNAMOS EL VALOR OBTENIDO
                return GetPrivateProfileInt(Section, Key, Default, vIniFile);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public bool WriteString(String Section, String Key, String Value)
        {
            try
            {
                // INTENTAMOS GUARDAR EL VALOR EN EL CONFIG INI Y REGRESAMOS True SI TODO SALE BIEN
                WritePrivateProfileString(Section, Key, Value, vIniFile);
                return true;
            }
            catch (Exception)
            {
                // SI HUBO UNA EXCEPCION REGRESAMOS FALSE
                return false;
            }
        }
        public bool WriteInt(String Section, String Key, int Value)
        {
            try
            {
                // INTENTAMOS GUARDAR EL VALOR SI TODO SALE BIEN REGRESAMOS True
                WritePrivateProfileInt(Section, Key, Value, vIniFile);
                return true;
            }
            catch (Exception ex)
            {
                // SI HUBO UNA EXCEPCION REGRESAMOS FALSE
                System.Diagnostics.Debug.Print("Error en WriteIni: " + ex.Message);
                return false;
            }
        }

        #endregion Metodos
    }
}

