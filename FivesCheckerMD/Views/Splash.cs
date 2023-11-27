using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace FivesCheckerMD
{
    public partial class Splash : Form
    {
        //Objeto para acceder a los metodos de keyGen
        private Function.keyGen keymet = new Function.keyGen();
        //Bandera que marca si el software tiene liscencia
        private bool licencia = false;

        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Shown(object sender, EventArgs e)
        {
            //Variable comodin para poder acceder al metodo keyGen.Generador()
            string comodin = string.Empty;
            //Se crea el directo Win para el registro
            Registry.CurrentUser.CreateSubKey("Software\\Win", RegistryKeyPermissionCheck.Default);
            //Comprobamos que exista Cotta en los registros de Windows
            if (Registry.CurrentUser.OpenSubKey("Software\\Win").GetValue("Cotta") != null)
            {
                //Generamos una Llave segun el lector que este conectado y la comparamos con la Llave existente en el registro Cotta de Windows
                licencia = keymet.Generador(comodin);
                if (licencia == true)
                {
                    //Le damos acceso al software al usuario
                    //Mandamos un OK al cerrar el Form para indicarle a Program.cs que ejecute frmPrincipal
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                }
                else
                {
                    //Variable que extrae el valor de CottaCert
                    string cert = Registry.CurrentUser.OpenSubKey("Software\\Win").GetValue("CottaCert").ToString();
                    if (cert != "False")
                    {
                        MessageBox.Show("La licencia ya no es valida.");
                        this.Close();
                    }
                    else
                    {
                        //Si la Lave generada por el lector no coincide con el registro Cotta, cerramos el software
                        MessageBox.Show("El lector no coincide con la licencia asignada a este software");
                        Environment.Exit(-1);
                    }
                }
            }
            else
            {
                MessageBox.Show("El software no ha sido licenciado.");
                this.Close();
            }
        }
    }
}
