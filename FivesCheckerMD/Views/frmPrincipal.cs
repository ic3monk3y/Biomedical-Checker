using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using FivesCheckerMD.Function;
using System.Threading;
using System.Diagnostics;

namespace FivesCheckerMD.Vistas
{
    // frmPrincipal hereda los metodos de CaptureForm
    public partial class frmPrincipal : CaptureForm
    {
        // Conexion sql
        private static Conexion db;
        // Objeto donde se extrae la funcion de verificar la huella
        private DPFP.Verification.Verification Verificator;

        public frmPrincipal()
        {
            db = new Conexion();
            InitializeComponent();
        }

        #region frmPrincipal
        //Funcion que manda a llamar Sp que genera el registro en la base de datos
        public void NvoRegistro(string IDemp, byte[] HuellaByte)
        {
            string PersonalID = string.Empty,
                   Nombre = string.Empty,
                   Puesto = string.Empty,
                   Jornada = string.Empty,
                   Foto = string.Empty,
                   txtCommand = string.Empty;
            byte[] FotoPersona = null;
            DataTable RegistroHuellas = new DataTable();

            RegistroHuellas = DatosPersonal.spDatosPersonal(IDemp, db.Conexionbd());
            if (RegistroHuellas.Rows.Count > 0)
            {
                lblNombre.Visible = true;
                lblPuesto.Visible = true;
                txtIncidencia.Visible = true;

                PersonalID = RegistroHuellas.Rows[0]["Personal"].ToString();
                Nombre = RegistroHuellas.Rows[0]["ApellidoPaterno"].ToString() + " " + RegistroHuellas.Rows[0]["ApellidoMaterno"].ToString() + " " + RegistroHuellas.Rows[0]["Nombre"].ToString();
                Puesto = RegistroHuellas.Rows[0]["Puesto"].ToString();
                //Jornada = RegistroHuellas.Rows[0]["Jornada"].ToString();
                FotoPersona = RegistroHuellas.Rows[0]["Foto"] as byte[];

                DataTable NuevoRegistro = new DataTable();
                string MsgIncidencia = String.Empty;

                NuevoRegistro = Registr.spNvoRegistr(PersonalID, "Registro", "INT", HuellaByte, db.Conexionbd());
                MsgIncidencia = NuevoRegistro.Rows[0]["Mensaje"].ToString();
                lblRegistro.Text = "";
                txtIncidencia.Text = MsgIncidencia;
                lblNombre.Text = Nombre;
                lblPuesto.Text = Puesto;
                try
                {
                    FotoPersonal.Image = byteArrayToImage(FotoPersona);
                }
                catch (Exception ex)
                {
                    //Si la foto de la base de datos es null, cargara la imagen preterminada cargada en el proyecto
                    FotoPersonal.Image = FivesCheckerMD.Properties.Resources.profile;
                }

                //Comando para ejecutar la aplicacion de consola de la Sincro
                Process miproceso = new Process();
                miproceso.StartInfo.FileName = @"C:\FivesChecker\FivesCheckerMD\SincroEjecucion\SincroEjecucion.exe";
                miproceso.StartInfo.UseShellExecute = false;
                miproceso.StartInfo.CreateNoWindow = true;
                miproceso.Start();
            }
            else
            {
                FotoPersonal.Image = FivesCheckerMD.Properties.Resources.profile;
                lblRegistro.Text = "Error al recuperar los datos";
            }
        }

        //Inicializa el reloj y la fecha, carga los diseños del path
        private void frmPrincipal_Load_1(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            lblHora2.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblFecha2.Text = DateTime.Now.ToLongDateString();

            //Carga de logo y diseños desde un path
            string pathLogo = @"C:\FivesChecker\Images\logo.png";
            string pathspr = @"C:\FivesChecker\Images\spr.png";
            string pathinfr = @"C:\FivesChecker\Images\infr.png";
            string pathsprdrch = @"C:\FivesChecker\Images\sprdrch.png";
            string pathbackprofile = @"C:\FivesChecker\Images\backProfilePic.jpg";
            picLogo.Image = new Bitmap(pathLogo);
            picLogo.BackColor = Color.Transparent;
            picLogo.Refresh();
            picTop.Image = new Bitmap(pathspr);
            picTop.BackColor = Color.Transparent;
            picTop.Refresh();
            picBottom.Image = new Bitmap(pathinfr);
            picBottom.BackColor = Color.Transparent;
            picBottom.Refresh();
            panel2.BackgroundImage = new Bitmap(pathsprdrch);
            picBottom.BackColor = Color.Transparent;
            picBottom.Refresh();
            picProfileBack.Image = new Bitmap(pathbackprofile);
            picProfileBack.BackColor = Color.Transparent;
            picProfileBack.Refresh();

            //Focus al textbox donde se ingresa la contraseña
            txtCaptura.Focus();
        }
        //Ni idea
        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            //ActEstaPresente("Matutino");
        }
        //Se declara los parametros para el reloj y la fecha
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            lblHora2.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblFecha2.Text = DateTime.Now.ToLongDateString();
        }

        //Ni idea x2
        private void ActEstaPresente(String Tipo)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = EstaPresente.spEstaPresente(Tipo, db.Conexionbd());
            }
            catch
            {
                MessageBox.Show("Error al ejecutar proceso.");
            }
        }

        //Funcion para convertir una imagen a arreglo de bytes
        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        //Funcion para convertir un arreglo de bytes a imagen
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            ms.Close();
            return returnImage;
        }

        //Boton para cerrar la aplicacion
        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            //Application.Exit();
            Environment.Exit(-1);
        }

        //Boton para minizar la aplicacion
        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Hypervinculo de la pagina de FivesSoftware
        private void linklblFivesSoft_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linklblFivesSoft.LinkVisited = true;
            //Funcion para abrir el navegador por defecto del sistema con la pagina https://www.fivesconsulting.com/
            System.Diagnostics.Process.Start("https://www.fivesconsulting.com/");
        }

        #endregion frmPrincipal

        #region Huella
        // Funcion que manda a llamar el registro de huella si la contraseña es correcta
        private void txtCaptura_KeyPress(object sender, KeyPressEventArgs e)
        {
            using (FivesEntities contexto = new FivesEntities())
            {
                
                if (e.KeyChar == (char)32)
                {
                    Conexion objconf = new Conexion();
                    string idemp = objconf.IDEmpresa();
                    try
                    {
                        //Conseguimos SucursalID de la tabla config buscando ID = 1
                        var suscursalID = from suc in contexto.Config where suc.ID == 1 select suc;
                        var resQuery = suscursalID.FirstOrDefault<Config>();
                        if (resQuery != null)
                        {
                            if (txtCaptura.Text == resQuery.UsuarioCFG)
                            {
                                txtCaptura.Text = "";
                                Stop();
                                Views.frmConfigContra preVentanaCaptura = new Views.frmConfigContra();
                                preVentanaCaptura.ShowDialog();
                                Start();
                            }
                            else
                            {
                                txtCaptura.Text = "";
                                MessageBox.Show("Contacta con un administrador.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error en la configuracion del Entity.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("App.exe.conf genera un error en la conexion.");
                    }
                }
            }
        }

        // Inicializacion del checador biometrico 
        protected override void Init()
        {
            base.Init();
            base.Text = "Verificación de Huella Digital";
            //Inicializa el objeto para la funcion verificar
            Verificator = new DPFP.Verification.Verification();
        }

        // El Process se ejecuta automaticamente cuando el lector termina de leer la huella (en el OnComplete de CaptureForm se manda a llamar el Process), entonces aqui ira el proceso de comparar la huella en la DB
        // Sobrecargamos el metodo Process para poder agregar la comparacion de huella
        // Como este metodo es de una clase y no se crearon modelos de la clase frmPrincipal, se usa funciones delegada para poder acceder a las propiedades de la vista de frmPrincipal
        protected override void Process(DPFP.Sample Sample)
        {
            // Se extrae el codigo base del Process original
            base.Process(Sample);

            // Bandera para la animacion de Buscando...
            int band = 1;

            // Conexion Entity / proceso de chequeo por huella
            using (FivesEntities contexto = new FivesEntities())
            {
                // Instancia donde se guarda la huella
                DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

                this.Invoke(new Ffunction(delegate () {
                    lblNombre.Visible = false;
                    lblPuesto.Visible = false;
                    txtIncidencia.Visible = false;

                }));

                if (features != null)
                {
                    //Objeto para guardar el resultado de la verificacion de la huella
                    DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

                    //Objeto donde se guardara la huella de la base de datos
                    DPFP.Template template2;
                    Stream stream;

                    try
                    {
                        //Conseguimos SucursalID de la tabla config buscando ID = 1
                        var suscursalID = from suc in contexto.Config where suc.ID == 1 select suc;
                        var resQuery = suscursalID.FirstOrDefault<Config>();
                        if (resQuery != null)
                        {
                            //Foreach que explora la query donde HuellaByte sea diferente de nulo y que SucursalID sea igual a la Sucurcal de la talba Config
                            foreach (var hue in contexto.Huella.Where(id => id.HuellaByte != null && id.SucursalID == resQuery.SucursalID))
                            {
                                //Variable necesaria para poder procesar el varbinary de la DB y convertirlo al tipo template 
                                stream = new MemoryStream(hue.HuellaByte);
                                template2 = new DPFP.Template(stream);

                                //Funcion de verificar la huella
                                Verificator.Verify(features, template2, ref result);
                                if (result.Verified)
                                {
                                    this.Invoke(new Ffunction(delegate () {
                                        NvoRegistro(hue.IDEmpleado, hue.HuellaByte);
                                    }));
                                    break;
                                }

                                //Animacion de busqueda
                                switch (band)
                                {
                                    case 1:
                                        this.Invoke(new Ffunction(delegate () {
                                            lblRegistro.Text = "Buscando.";
                                        }));
                                        break;
                                    case 2:
                                        this.Invoke(new Ffunction(delegate () {
                                            lblRegistro.Text = "Buscando..";
                                        }));
                                        break;
                                    case 3:
                                        this.Invoke(new Ffunction(delegate () {
                                            lblRegistro.Text = "Buscando...";
                                        }));
                                        band = 0;
                                        break;
                                }
                                band++;
                            }

                            // Si no encontro ninguna coincidencia, Se buscara en todas las huellas de BD diferente de nulo
                            if (!result.Verified)
                            {
                                //Foreach donde se requere toda la query del entity donde el campo HuellaByte sea diferente de nulo
                                foreach (var hue in contexto.Huella.Where(id => id.HuellaByte != null))
                                {
                                    //Variable necesaria para poder procesar el varbinary de la DB y convertirlo al tipo template 
                                    stream = new MemoryStream(hue.HuellaByte);
                                    template2 = new DPFP.Template(stream);

                                    //Funcion de verificar la huella
                                    Verificator.Verify(features, template2, ref result);
                                    if (result.Verified)
                                    {
                                        this.Invoke(new Ffunction(delegate () {
                                            NvoRegistro(hue.IDEmpleado, hue.HuellaByte);
                                        }));
                                        break;
                                    }

                                    //Animacion de busqueda
                                    switch (band)
                                    {
                                        case 1:
                                            this.Invoke(new Ffunction(delegate () {
                                                lblRegistro.Text = "Buscando.";
                                            }));
                                            break;
                                        case 2:
                                            this.Invoke(new Ffunction(delegate () {
                                                lblRegistro.Text = "Buscando..";
                                            }));
                                            break;
                                        case 3:
                                            this.Invoke(new Ffunction(delegate () {
                                                lblRegistro.Text = "Buscando...";
                                            }));
                                            band = 0;
                                            break;
                                    }
                                    band++;
                                }
                                // Si no encontro ninguna coincidencia, ya se muestra el mensaje de "No se encontro la huella"
                                if (!result.Verified)
                                {
                                    this.Invoke(new Ffunction(delegate ()
                                    {
                                        FotoPersonal.Image = FivesCheckerMD.Properties.Resources.profile;
                                        lblRegistro.Text = "No se encontro la Huella.";
                                    }));
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("App.exe.conf genera un error en la conexion.");
                    }
                    

                }
            }
        }

        #endregion Huella

    }
}
