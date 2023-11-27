using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FivesCheckerMD.Views
{
    public partial class frmConfigContra : Form
    {
        public frmConfigContra()
        {
            InitializeComponent();
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)32)
            {
                using (FivesEntities contexto = new FivesEntities())
                {
                    try
                    {
                        var suscursalID = from suc in contexto.Config where suc.ID == 1 select suc;
                        var resQuery = suscursalID.FirstOrDefault<Config>();
                        if (resQuery != null)
                        {
                            if (txtContra.Text == resQuery.PassCFG)
                            {
                                txtContra.Text = "";
                                Vistas.frmRegistrar preVentanaCaptura = new Vistas.frmRegistrar();
                                preVentanaCaptura.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                txtContra.Text = "";
                                MessageBox.Show("Contacta con un administrador.");
                            }
                        }
                        else
                        {
                            txtContra.Text = "";
                            MessageBox.Show("No esta configurado el checador.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("App.exe.conf genera un error en la conexion.");
                    }
                }
            }

            if (e.KeyChar == (char)27)
            {
                this.Close();
            }

        }
    }
}
