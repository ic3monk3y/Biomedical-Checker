using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using System.Diagnostics;
using System.Threading;

namespace FivesCheckerMD.Vistas
{
    public partial class frmRegistrar : Form
    {
        //Conexion sql
        private static Function.Conexion db;

        private byte[] huellaByte;
        private int mano = 0;
        //Objeto donde se guardara la huella de un clase externa, en este caso CapturarHuella
        private DPFP.Template Template;

        public frmRegistrar()
        {
            //Inicializa la conexion sql
            db = new Function.Conexion();
            InitializeComponent();
        }

        #region frmRegistrar
        private void frmRegistrar_Load(object sender, EventArgs e)
        {
            Function.PendientesSincro pendientes = new Function.PendientesSincro();
            DataTable pendINT = new DataTable();
            pendINT = pendientes.slctPendientesSincro(db.Conexionbd());
            int conteo = pendINT.Rows.Count;
            if (!pendientes.actCatch)
                txtPendientes.Text = "Pendientes " + conteo.ToString();
            else
                txtPendientes.Text = "Error.";

            rdbtPulgar.Checked = true;
            cmbMano.Items.Add("Izquierda");
            cmbMano.Items.Add("Derecha");
            //Se establece la mano izquierda como la preterminada
            cmbMano.SelectedIndex = 1;
            
            Listar();
        }

        //Funcion para validar los Datos del Forms y guardar en la base de datos
        private void btnGrd_Click(object sender, EventArgs e)
        {

            string idemp = (string)cmbEmp.SelectedValue;
            
            //Conexion entity
            
                //If que valida que mano fue seleccionada y segun la mano, el dedo
                if (cmbMano.SelectedIndex == 0)
                {
                    if (rdbtPulgar.Checked == true)
                        mano = 1;
                    if (rdbtIndice.Checked == true)
                        mano = 2;
                    if (rdbtMedio.Checked == true)
                        mano = 3;
                    if (rdbtAnular.Checked == true)
                        mano = 4;
                    if (rdbtMenique.Checked == true)
                        mano = 5;
                }
                else if (cmbMano.SelectedIndex == 1)
                {
                    if (rdbtPulgar.Checked == true)
                        mano = 6;
                    if (rdbtIndice.Checked == true)
                        mano = 7;
                    if (rdbtMedio.Checked == true)
                        mano = 8;
                    if (rdbtAnular.Checked == true)
                        mano = 9;
                    if (rdbtMenique.Checked == true)
                        mano = 10;
                }
            
            using (FivesEntities contexto = new FivesEntities())
            {
                //If para comprobar que la huella haya sido capturada
                if (Template != null)
                {
                    //Objeto para acceder a los metodos y variables de HuellaRegistro
                    Function.HuellaRegistro spValidacion = new Function.HuellaRegistro();

                    huellaByte = Template.Bytes;
                    //Variable que almacena la comprobacion de que un dedo a sido registrada registrado con anterioridad, y segun el resultado, saber que mensaje mostrar
                    bool bandera = contexto.Huella.Where(x => x.IDEmpleado == idemp && x.Dedo == mano && x.HuellaByte != null).Any();
                    //SP que se usa para hacer insert o update de una huella
                    spValidacion.spRegistroHuellas(idemp, mano, huellaByte,db.Conexionbd());

                    //Mensaje a mostrar mientras que no se haya invocado el Catch en la funcion spRegistroHuellas
                    if (bandera == true && spValidacion.actCatch == false)
                        MessageBox.Show("Huella actualizada");
                    else if (bandera == false && spValidacion.actCatch == false)
                        MessageBox.Show("Huella registrada");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sin una huella, no se puede guardar la informacion");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
           }
        }

        //Llenado del comboBox con los empleados en base a la DB
        private void Listar() 
        {
            using (FivesEntities contexto = new FivesEntities())
            {
                try
                {
                    List<Function.EmpViewModel> lstemp = new List<Function.EmpViewModel>();
                    //Conseguimos el id de la sucursal de la tabla config
                    var suscursalID = from suc in contexto.Config where suc.ID == 1 select suc;
                    var resQuery = suscursalID.FirstOrDefault<Config>();
                    if (resQuery != null)
                    {
                        //Se rellena la lista con el modelo EmpViewModel, del modelo solo se selecciona a los empleados activos y se ordena por IDEmpleado
                        lstemp = (from conn in contexto.Personal
                                  select new Function.EmpViewModel
                                  {
                                      Personal = conn.Personal1,
                                      Nombre = conn.Personal1 + ": " + conn.Nombre + " " + conn.ApellidoPaterno + " " + conn.ApellidoMaterno,
                                      Estatus = conn.EstatusID,
                                      Sucursal = conn.SucursalID
                                  }).Where(id => id.Estatus == 1 && id.Sucursal == resQuery.SucursalID).OrderBy(id => id.Personal).ToList();
                        //Llenado del combobox con la lista con los datos del objeto del entity
                        cmbEmp.DataSource = lstemp;
                        cmbEmp.ValueMember = "Personal";
                        cmbEmp.DisplayMember = "Nombre";
                    }
                    else
                        MessageBox.Show("No esta configurado el checador.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("App.exe.conf genera un error en la conexion.");
                }  
            }
        }
        #endregion frmRegistar

        #region Huella
        //Invocacion de la Ventana CapturarHuella para Generar el objeto template donde se almacenara la huella de la huella 
        private void btnHuella_Click(object sender, EventArgs e)
        {
            CapturarHuella ventanaCaptura = new CapturarHuella();
            //Aqui se almacena/Iguala la huella en el OnTemplate de ambas clases
            ventanaCaptura.OnTemplate += this.OnTemplate;
            ventanaCaptura.ShowDialog();
            if (Template != null)
                huellaByte = Template.Bytes;
            else
                MessageBox.Show("No capturaste la huella");
        }

        //Funcion donde se almacena la huella de CapturarHuella en el objeto template
        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Ffunction(delegate ()
            {
                Template = template;
                if (Template != null)
                {
                    MessageBox.Show("Creacion de plantilla correctamente.", "Fingerprint Enrollment");
                    txtHuella.Text = "Huella capturada correctamente";
                }
                else
                {
                    MessageBox.Show("Creacion de plantilla Erroneamente.", "Fingerprint Enrollment");
                    txtHuella.Text = "Huella capturada erroneamente";
                }
            }));
        }


        #endregion Huella

        private void btnConf_Click(object sender, EventArgs e)
        {
            Views.frmConfig ventConfig = new Views.frmConfig();
            ventConfig.ShowDialog();
        }

        private void btnSincro_Click(object sender, EventArgs e)
        {
            Thread cmd = new Thread(new ThreadStart(SincroManual));
            cmd.Start();
            //Join bloquea main y espera que termine el hilo ejecutado
            //cmd.Join();
        }

        private void SincroManual ()
        {
            Function.PendientesSincro pendientes = new Function.PendientesSincro();
            DataTable pendINT = new DataTable();

            do
            {
                Process miproceso = new Process();
                miproceso.StartInfo.FileName = @"C:\FivesChecker\App\SincroApiFivesChecker.exe";
                miproceso.StartInfo.UseShellExecute = false;
                miproceso.StartInfo.CreateNoWindow = true;
                miproceso.Start();

                pendINT = pendientes.slctPendientesSincro(db.Conexionbd());


                if (!pendientes.actCatch)
                    txtPendientes.Text = "Pendientes " + pendINT.Rows.Count.ToString();
                else
                    txtPendientes.Text = "Error.";

            } while (pendINT.Rows.Count > 0);
        }

    }
}
