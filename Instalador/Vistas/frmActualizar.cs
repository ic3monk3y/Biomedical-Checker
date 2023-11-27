using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Instalador.Funciones;

namespace Instalador.Vistas
{
    public partial class frmActualizar : Form
    {
        Conexion conn;
        DataTable datos = new DataTable();
        public frmActualizar(DataTable dt)
        {
            conn = new Conexion();
            datos = dt;
            
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            ActualizarApp appAct = new ActualizarApp();
            appAct.ActualizarBackEnd(datos, conn).Wait();
            this.Hide();
            frmDescargar frm = new frmDescargar(datos);
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
    }
}
