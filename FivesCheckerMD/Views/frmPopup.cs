using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace FivesCheckerMD.Views
{
    
    public partial class frmPopup : Form
    {
        //Objeto para acceder a los metodos de Function.keyGen
        Function.keyGen HWid = new Function.keyGen();
        //Variable donde se guarda el ClassGUID del lector 
        private string[] clave;
        //Variable donde se guarda la Llave escrita por el usuario
        private string llave = string.Empty;

        public frmPopup()
        {
            InitializeComponent();
        }

        private void frmPopup_Shown(object sender, EventArgs e)
        {
            if (Registry.CurrentUser.OpenSubKey("Software\\Win").GetValue("CottaCert") != null)
            {
                btnRegistrar.Text = "Actualizar Llave";
                if (Registry.CurrentUser.OpenSubKey("Software\\Win").GetValue("CottaCert").ToString() == "True")
                    if (Registry.CurrentUser.OpenSubKey("Software\\Win").GetValue("CottaDate") != null)
                        Registry.CurrentUser.CreateSubKey("Software\\Win").DeleteValue("CottaDate");
            }
                
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Metodo para obtener el ClassGUID del lector conectado
        private void btnHWid_Click(object sender, EventArgs e)
        {
            //Validamos que este conectado el lector
            if (HWid.lectorConectado() == false)
                MessageBox.Show("Por favor conecta el lector para poder obtener su ID");
            else
            {
                //Mostramos la ClassGUID obtenida ya procesado
                clave = HWid.DatosHW();
                txtID.Text = clave[0] + "-" + clave[1] + "-" + clave[2] + "-" + clave[3] + "-" + clave[4];
                MessageBox.Show("Por favor manda esta clave por correo.");
            }
        }
        //Metodo para validar la Llave escrita por el usuario
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Validamos que el lector este conectado
            if (HWid.lectorConectado() == false)
                MessageBox.Show("Por favor conecta el lector para poder registrar la Llave.");
            else
            {
                //Validamos que no esten vacios los campos
                if (txtclvA.Text == "" && txtclvB.Text == "" && txtclvC.Text == "" && txtclvD.Text == "" && txtclvE.Text == "" && txtclvF.Text == "")
                    MessageBox.Show("Por favor escribe una Llave.");
                else
                {
                    //variable donde se almacena la suma de las longitudes de los campos de la Llave
                    int llaveCompleta = txtclvA.TextLength + txtclvB.TextLength + txtclvC.TextLength + txtclvD.TextLength + txtclvE.TextLength + txtclvF.TextLength;
                    //Validamos que se haya escrito todos los caracteres de la Llave
                    if (llaveCompleta != 36)
                        MessageBox.Show("Por favor ingresa la Llave completa.");
                    else
                    {
                        //Convertimos los campos escritos en mayusculas
                        txtclvA.CharacterCasing = CharacterCasing.Upper;
                        txtclvB.CharacterCasing = CharacterCasing.Upper;
                        txtclvC.CharacterCasing = CharacterCasing.Upper;
                        txtclvD.CharacterCasing = CharacterCasing.Upper;
                        txtclvE.CharacterCasing = CharacterCasing.Upper;
                        txtclvF.CharacterCasing = CharacterCasing.Upper;
                        llave = txtclvA.Text + "-" + txtclvB.Text + "-" + txtclvC.Text + "-" + txtclvD.Text + "-" + txtclvE.Text + "-" + txtclvF.Text;
                        //Validamos que la Llave escrita sea la misma que genera el lector conectado
                        if (HWid.Generador(llave))
                        {
                            //Se crea el registro Cotta y se le almacena la Llave escrita por el usuario.
                            Registry.CurrentUser.CreateSubKey("Software\\Win", RegistryKeyPermissionCheck.Default);
                            Registry.CurrentUser.CreateSubKey("Software\\Win").SetValue("Cotta", llave);
                            Registry.CurrentUser.CreateSubKey("Software\\Win").SetValue("CottaDate", txtclvB.Text);
                            Registry.CurrentUser.CreateSubKey("Software\\Win").SetValue("CottaCert", "False");
                            Registry.CurrentUser.CreateSubKey("Software\\Win").Close();
                            MessageBox.Show("Llave validada y registrada, por favor vuelve abrir el software.");
                            Application.Exit();
                        }
                        else
                            MessageBox.Show("La Llave ingresada no es compatible con el lector conectado.");
                    }
                }
            }
        }

        private void txtclvA_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtclvA.Text.Length == 6)
                txtclvB.Focus();
        }
        private void txtclvB_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtclvB.Text.Length == 6)
                txtclvC.Focus();
        }
        private void txtclvC_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtclvC.Text.Length == 6)
                txtclvD.Focus();
        }
        private void txtclvD_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtclvD.Text.Length == 6)
                txtclvE.Focus();
        }
        private void txtclvE_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtclvE.Text.Length == 6)
                txtclvF.Focus();
        }
        private void txtclvF_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtclvF.Text.Length == 6)
                btnRegistrar.Focus();
        }

        #region VentanaMovible
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
