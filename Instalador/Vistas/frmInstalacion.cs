using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Instalador.Vistas
{
    public partial class frmInstalacion : Form
    {
        private bool banderaProceso = false;

        public frmInstalacion()
        {
            InitializeComponent();
        }

        private void btnInstalar_Click(object sender, EventArgs e)
        {
            if (btnInstalar.Text == "Terminar" && banderaProceso == true)
            {
                Application.Exit();
            }

            if (!banderaProceso)
            {
                btnInstalar.Text = "Instalando...";
                btnInstalar.Enabled = false;

                string archivo = @"C:\FivesChecker\FCV6.rar";
                string carpeta = @"C:\FivesChecker\";

                Process p = new Process();
                p.StartInfo.FileName = @"C:\Program Files\WinRAR\WinRAR.exe";
                p.StartInfo.CreateNoWindow = false;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.Arguments = string.Format("x -o+ \"{0}\" \"{1}\"", archivo, carpeta);
                p.EnableRaisingEvents = true;
                p.Start();
                p.WaitForExit();

                Process p2 = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\installutil.exe";
                startInfo.Arguments = @"-i ""C:\FivesChecker\Data\FivesSincro.exe""";
                p2.StartInfo = startInfo;
                p2.Start();
                p2.WaitForExit();

                File.Delete(archivo);

                lblTexto1.Text = "Termino el proceso de instalacion, presione";
                lblTexto2.Text = @"el boton ""Terminar"" para salir.";

                btnInstalar.Text = "Terminar";
                btnInstalar.Enabled = true;
                banderaProceso = true;
            }
        }
    }
}
