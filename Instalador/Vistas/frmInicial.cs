using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instalador.Vistas
{
    public partial class frmInicial : Form
    {
        DataTable datos = new DataTable();
        public frmInicial(DataTable dt)
        {
            datos = dt;
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDescargar frm = new frmDescargar(datos);
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
    }
}
