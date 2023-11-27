using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FivesCheckerMD.Views
{
    public partial class frmConfig : Form
    {
        //Conexion sql
        private static Function.Conexion db;
        Function.CambioConfigFC spCmbConf;

        public frmConfig()
        {
            InitializeComponent();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            string Sucursal = string.Empty;
            DataTable ejecucion = new DataTable();
            db = new Function.Conexion();
            spCmbConf = new Function.CambioConfigFC();
            ejecucion = spCmbConf.spCambioConfigFC("", "", 0, 1, db.Conexionbd());
            if (!spCmbConf.actCatch && ejecucion.Rows.Count > 0)
            {
                Listar();
                txtUsuario.Text = ejecucion.Rows[0]["Usr"].ToString();
                txtContra.Text = ejecucion.Rows[0]["Pass"].ToString();
                txtConfirmacion.Text = ejecucion.Rows[0]["Pass"].ToString();
                Sucursal = ejecucion.Rows[0]["Scrl"].ToString();
                cmbSuc.SelectedIndex = cmbSuc.FindStringExact(Sucursal);
            }
            else
            {
                MessageBox.Show("Error al recuperar los datos del conig.");
                this.Close();
            }
                
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtConfirmacion.Text == txtContra.Text)
            {
                db = new Function.Conexion();
                spCmbConf = new Function.CambioConfigFC();
                DataTable ejecucion = new DataTable();

                string usr = txtUsuario.Text,
                       contra = txtContra.Text;

                int idsuc = (int)cmbSuc.SelectedValue;

                ejecucion = spCmbConf.spCambioConfigFC(usr, contra, idsuc, 2, db.Conexionbd());

                if (!spCmbConf.actCatch)
                {
                    MessageBox.Show("Configuracion guardada exitosamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    this.DialogResult = DialogResult.Abort;
                    MessageBox.Show("No se logro guardar la configuracion.");
                }
            }
            else
                MessageBox.Show("No coinciden las contraseñas.");
            
        }

        //Llenado del comboBox con las sucrusales en base a la DB
        private void Listar()
        {
            using (FivesEntities contexto = new FivesEntities())
            {
                List<Function.SucViewModel> lstsuc = new List<Function.SucViewModel>();

                //Se rellena la lista con el modelo EmpViewModel, del modelo solo se selecciona a los empleados activos y se ordena por IDEmpleado
                lstsuc = (from conn in contexto.Sucursales
                            select new Function.SucViewModel
                            {
                                sucursal = conn.SincroID,
                                Sucursalid = conn.ID,
                                estatus = (int)conn.Estatus
                            }).Where(id => id.estatus == 1).OrderBy(id => id.Sucursalid).ToList();
                //Llenado del combobox con la lista con los datos del objeto del entity
                cmbSuc.DataSource = lstsuc;
                cmbSuc.ValueMember = "Sucursalid";
                cmbSuc.DisplayMember = "sucursal"; 
            }
        }

        private void chckContra_CheckedChanged(object sender, EventArgs e)
        {
            if(chckContra.Checked == true)
                txtContra.PasswordChar = '\0';
            else
                txtContra.PasswordChar = '*';

        }

        private void chckConfir_CheckedChanged(object sender, EventArgs e)
        {
            if (chckConfir.Checked == true)
                txtConfirmacion.PasswordChar = '\0';
            else
                txtConfirmacion.PasswordChar = '*';

        }
    }
}
