using System;
using System.Text;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;

namespace FivesCheckerMD.Function
{
    class keyGen
    {
        //cadena para almacenar el ClassGUID
        string HWid = String.Empty;
        //Arreglo para almacer el ClassGUID diseccionada
        string[] HWidSplit,
                 HWidPreSplit;
        //bandera que inidica si esta conectado el lector de huellas
        bool bandQuery = false;
        //Cadena donde se guarda la Llave generada
        string serie = string.Empty;

        //Obtiene los valores del lector necesarios para poder generar una Llave
        public string[] DatosHW()
        {
            //Objeto para poder acceder a los metodos de Windows.WIn32 y poder almacenar lo obtenido de los metodos}
            ManagementObjectCollection mbsList = null;
            //Objeto donde se ejecuta el metodo buscar y se le manda la query con el nombre del lector
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_PnPEntity Where Name like '%U.are.U®%'");
            mbsList = mbs.Get();

            foreach (ManagementObject mo in mbsList)
            {
                //Al poderse ejecutar la query significa que el lector esta conectado y se marca la bandera con un true
                bandQuery = true;
                //campo de la tabla que almacena el classGUID
                HWid = mo["DeviceID"].ToString();

            }

            if (bandQuery == true)
            {
                //xxxxxx
                HWidPreSplit = HWid.Split('\\');
                //Eliminamos las llaves {} que vienen con la cadena extraida
                HWid = HWidPreSplit[2].Trim(new Char[] { '{', '}' });
                //Dividimos la cadena original cada vez que se encentre un '-'
                HWidSplit = HWid.Split('-');
            }

            return HWidSplit;
        }

        //Genera una Llave segun el lector conectado 
        public bool Generador(string llv)
        {
            DatosHW();

            //Al estar conectado el lector se puede llenar automaticamente los campos del classGUID
            if (bandQuery == true)
            {
                //Variable donde se almacenara los valores ASCII
                int intv1 = 0,
                    intv2 = 0,
                    intv3 = 0,
                    intv4 = 0,
                    intv5 = 0,
                    intv6 = 0;
                //Variables donde se almacenara las cadenas hexadecimales
                string hexv1 = string.Empty,
                       hexv2 = string.Empty,
                       hexv3 = string.Empty,
                       hexv4 = string.Empty,
                       hexv5 = string.Empty,
                       hexv6 = "MULA";
                //Variables temporales para poder almacenar como valor numerico las cadenas originales
                byte[] tempByte1, tempByte2;
                //Variable para almacenar la fecha en hexadecimal que se usa para generar la Llave
                string fchhex = FchToHex();
                DateTime hoy = DateTime.Now;

                //La cadena de cada textbox se divide en dos subcadenas y se obtiene el valor ASCII del primer caracter de cada subcadena 
                //Luego se suman entre ellos
                tempByte1 = Encoding.ASCII.GetBytes(HWidSplit[0].Substring(0, 4));
                tempByte2 = Encoding.ASCII.GetBytes(HWidSplit[0].Substring(4, 4));
                intv1 = (tempByte1[0] + tempByte1[1] + tempByte1[2] + tempByte1[3]) + (tempByte2[0] + tempByte2[1] + tempByte2[2] + tempByte2[3]);

                tempByte1 = Encoding.ASCII.GetBytes(HWidSplit[2].Substring(0, 2));
                tempByte2 = Encoding.ASCII.GetBytes(HWidSplit[2].Substring(2, 2));
                intv3 = (tempByte1[0] + tempByte1[1]) + (tempByte2[0] + tempByte2[1]);

                tempByte1 = Encoding.ASCII.GetBytes(HWidSplit[1].Substring(0, 2));
                tempByte2 = Encoding.ASCII.GetBytes(HWidSplit[1].Substring(2, 2));
                intv2 = (tempByte1[0] + tempByte1[1]) + (tempByte2[0] + tempByte2[1]);

                tempByte1 = Encoding.ASCII.GetBytes(hexv6);
                intv6 = (tempByte1[0] + tempByte1[1] + tempByte1[2] + tempByte1[3]);

                tempByte1 = Encoding.ASCII.GetBytes(HWidSplit[4].Substring(0, 6));
                tempByte2 = Encoding.ASCII.GetBytes(HWidSplit[4].Substring(6, 6));
                intv5 = (tempByte1[0] + tempByte1[1] + tempByte1[2] + tempByte1[3] + tempByte1[4] + tempByte1[5]) + (tempByte2[0] + tempByte2[1] + tempByte2[2] + tempByte2[3] + tempByte2[4] + tempByte2[5]);

                tempByte1 = Encoding.ASCII.GetBytes(HWidSplit[3].Substring(0, 2));
                tempByte2 = Encoding.ASCII.GetBytes(HWidSplit[3].Substring(2, 2));
                intv4 = (tempByte1[0] + tempByte1[1]) + (tempByte2[0] + tempByte2[1]);

                //El valor obtenido de la suma de los valores ASCII se le suma una multiplicacion que es el factor al azar del keygen
                intv1 = intv1 + (666 * 17700);
                intv3 = intv3 + (intv2 * 55432);
                //intv2 = intv2 + (77 * 15880);
                intv6 = intv6 + (intv5 * 54902);
                intv5 = intv5 + (intv4 * 58746);
                intv4 = intv4 + (999 * 68071);

                //Al final se convierte en una cadena hexadecimal
                hexv1 = intv1.ToString("X");
                hexv3 = intv3.ToString("X");
                //hexv2 = intv2.ToString("X");
                hexv6 = intv6.ToString("X");
                hexv5 = intv5.ToString("X");
                hexv4 = intv4.ToString("X");

                hexv2 = fchhex;

                //Creamos una subcadena de 6 caracteres de cada cadena hexadecimal y la guardamos en una variable
                //Este ya es la clave generada
                serie = hexv1.Substring(0, 6) + "-" + hexv2 + "-" + hexv3.Substring(0, 6) + "-" + hexv4.Substring(0, 6) + "-" + hexv5.Substring(0, 6) + "-" + hexv6.Substring(0, 6);
                //Comprobamos que si el comodin llego vacio o con un valor
                if (llv != string.Empty)
                {
                    //Comprobamos que la Llave escrita por el usuario sea igual que la generada por el lector
                    if (llv == serie)
                        return true;
                    else
                        return false;
                } 
                else
                {
                    //Variable que extrae el valor de Cotta
                    string clv = Registry.CurrentUser.OpenSubKey("Software\\Win").GetValue("Cotta").ToString();
                    //Variable que extrae el valor de CottaCert
                    string cert = Registry.CurrentUser.OpenSubKey("Software\\Win").GetValue("CottaCert").ToString();
                    //Arreglo donde se almacena Cotta diseccionada para usar la segunda posicion en ObFecha()
                    string[] clave = clv.Split('-');
                    //Comprobamos que la Llave generada por el lector sea igual que la Llave registrada en Cotta
                    //y comprobamos que no se haya vencido la licencia
                    if (serie == clv && ObFecha(clave[1]) == false && cert == "False")
                        return true;
                    else
                        return false;
                }
            }
            else
            {
                MessageBox.Show("El lector no se encuentra conectado");
                
                return false;
            }
        }

        //Genera la segunda seccion de la Llave segun la fecha del registro
        private string FchToHex()
        {
            string fchtohex = String.Empty;
            //Variables para almacenar el valor hexadecimal de la fecha
            string fchstrdd = String.Empty,
                   fchstrmm = String.Empty,
                   fchstraa = String.Empty,
                   fch = String.Empty;
            //Variables para alamcenar el valor decimal de la fecha
            int fchintdd = 0,
                fchintmm = 0,
                fchintaa = 0;
            DateTime dt1 = DateTime.Now;

            if (Registry.CurrentUser.OpenSubKey("Software\\Win").GetValue("CottaDate") != null)
            {
                string claveStr = Registry.CurrentUser.OpenSubKey("Software\\Win").GetValue("CottaDate").ToString();
                return claveStr;
            }
            else
            {
                //Fecha para el keyGen
                //Extraemos la fecha diseccionada
                fchstrdd = dt1.ToString("dd");
                fchstrmm = dt1.ToString("MM");
                fchstraa = dt1.ToString("yy");


                //Convertimos cada seccion de la fecha en int
                //Se le suma un numero de 14 al 16 para agregar un factor de aletoriedad
                //Comprobamos el valor en decimal si es menor o igual que 15, se le agrega un 0 para evitar que tenga un solo digito el valor hexadecimal
                fchintdd = Convert.ToInt32(fchstrdd) + 16;
                if (fchintdd <= 15)
                    fchstrdd = "0" + fchintdd.ToString("X");
                else
                    fchstrdd = fchintdd.ToString("X");

                fchintmm = Convert.ToInt32(fchstrmm) + 15;
                if (fchintmm <= 15)
                    fchstrmm = "0" + fchintmm.ToString("X");
                else
                    fchstrmm = fchintmm.ToString("X");

                fchintaa = 1 + Convert.ToInt32(fchstraa) + 14;
                if (fchintaa <= 15)
                    fchstraa = "0" + fchintaa.ToString("X");
                else
                    fchstraa = fchintaa.ToString("X");

                //La segundo seccion de la Llave se le asigna la fecha en hexadecimal (dd/mm/aa)
                fch = fchstrdd + fchstrmm + fchstraa;

                return fch;
            }
        }

        //Marca una bandera boleana si el lector esta o no conectado
        public bool lectorConectado()
        {
            bool band = false;
            //Objeto para poder acceder a los metodos de Windows.WIn32 y poder almacenar lo obtenido de los metodos}
            ManagementObjectCollection mbsList = null;
            //Objeto donde se ejecuta el metodo buscar y se le manda la query con el nombre del lector
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_PnPEntity Where Name like '%U.are.U®%'");
            mbsList = mbs.Get();

            foreach (ManagementObject mo in mbsList)
            {
                //Al poderse ejecutar la query significa que el lector esta conectado y se marca la bandera con un true
                band = true;
            }

            return band;
        }

        //Marca una badnera boleana si la fecha de la licencia se vencio
        private bool ObFecha(string claveStr)
        {
            //Bandera que marca si se vencio la licencia
            bool vencimiento = false;
            //Varaibles date para comparar fechas
            DateTime hoy = DateTime.Now;
            DateTime fecha;
            //Seccionamos la casena de la fecha hexadecimal en dia, mes y año
            string dia = claveStr.Substring(0, 2),
                   mes = claveStr.Substring(2, 2),
                   ano = claveStr.Substring(4, 2),
                   fechaStr = String.Empty;
            //Convertimos de string hexadecimal  a int decimal, le restamos el factor de aletoriedad
            int decDia = Convert.ToInt32(dia, 16) - 16,
                decMes = Convert.ToInt32(mes, 16) - 15,
                decAno = Convert.ToInt32(ano, 16) - 14;

            //Para evitar que algun valor se muestre con un solo dijito, se le agrega un 0 si es menor a 10
            if (decDia < 10)
                dia = "0" + decDia.ToString();
            else
                dia = decDia.ToString();

            if (decMes < 10)
                mes = "0" + decMes.ToString();
            else
                mes = decMes.ToString();

            if (decAno < 10)
                ano = "0" + decAno.ToString();
            else
                ano = decAno.ToString();

            //Juntamos los valores en una sola caena y le damos formato
            fechaStr = dia + "/" + mes + "/20" + ano;
            //Convertimos la cadena a fecha
            fecha = Convert.ToDateTime(fechaStr);
            //Comparamos la fecha actual con la fecha de vencimineto de la licencia, si es mayor devuelve true ya que se vencio la licencia
            if (hoy > fecha)
            {
                vencimiento = true;
                Registry.CurrentUser.CreateSubKey("Software\\Win").SetValue("CottaCert", vencimiento);
                return vencimiento;
            }
            else
            {
                return vencimiento;
            }
        }
    }
}
